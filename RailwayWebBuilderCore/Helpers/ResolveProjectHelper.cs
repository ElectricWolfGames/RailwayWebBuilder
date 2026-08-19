using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RailwayWebBuilderCore.Helpers;

/// <summary>
/// Writes a DaVinci Resolve project export (.drp) for a layout, by taking a template
/// export and swapping the placeholder text of its Text+ tools.
///
/// A .drp is a zip holding project.xml and one timeline xml per sequence. Each Text+
/// lives in a CompositionBA element, which is hex encoded and compressed twice:
///
///     [4 byte big endian length][zlib]
///         "...data" [4 byte big endian length]"Composition { ... }" \0
///             [4 byte little endian length][zlib]
///                 StyledText = Input { Value = "TITLE", }
///
/// All three lengths have to be rewritten when the text changes, or Resolve reads a
/// truncated composition and the tool loads with no controls at all.
/// </summary>
public static class ResolveProjectHelper
{
    private const string CompositionMarker = "Composition {";

    /// <summary>
    /// Writes a copy of the template with its TITLE and DESCRIPTION placeholders replaced.
    /// </summary>
    public static bool Write(string templateDrp, string outputDrp, string title, string description)
    {
        if (!File.Exists(templateDrp))
            return false;

        Dictionary<string, string> replacements = new()
        {
            ["TITLE"] = title ?? string.Empty,
            ["DESCRIPTION"] = description ?? string.Empty,
        };

        string workingFolder = Path.Combine(Path.GetTempPath(), "drp_" + Guid.NewGuid().ToString("N"));

        try
        {
            ZipFile.ExtractToDirectory(templateDrp, workingFolder);

            foreach (string xmlFile in Directory.GetFiles(workingFolder, "*.xml", SearchOption.AllDirectories))
                RewriteCompositions(xmlFile, replacements);

            RewriteProjectName(workingFolder, Path.GetFileNameWithoutExtension(outputDrp));

            if (File.Exists(outputDrp))
                File.Delete(outputDrp);

            ZipFile.CreateFromDirectory(workingFolder, outputDrp, CompressionLevel.Optimal, false);
            return true;
        }
        catch (IOException)
        {
            return false;
        }
        finally
        {
            if (Directory.Exists(workingFolder))
                Directory.Delete(workingFolder, true);
        }
    }

    /// <summary>
    /// Trims to a whole word, so a description does not stop mid word.
    /// </summary>
    public static string Cap(string text, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(text) || text.Length <= maxLength)
            return text ?? string.Empty;

        string trimmed = text.Substring(0, maxLength - 3);
        int lastSpace = trimmed.LastIndexOf(' ');

        if (lastSpace > 0)
            trimmed = trimmed.Substring(0, lastSpace);

        return trimmed.TrimEnd(',', '.', ';', ' ') + "...";
    }

    private static byte[] Deflate(byte[] data)
    {
        using MemoryStream output = new();
        using (ZLibStream zip = new(output, CompressionLevel.Optimal))
            zip.Write(data, 0, data.Length);

        return output.ToArray();
    }

    private static int IndexOfInnerStream(byte[] data)
    {
        for (int index = 0; index < data.Length - 1; index++)
        {
            if (data[index] == 0x78 && (data[index + 1] == 0xDA || data[index + 1] == 0x9C))
                return index;
        }

        return -1;
    }

    private static byte[] Inflate(byte[] data, int offset)
    {
        using MemoryStream input = new(data, offset, data.Length - offset);
        using ZLibStream zip = new(input, CompressionMode.Decompress);
        using MemoryStream output = new();

        zip.CopyTo(output);
        return output.ToArray();
    }

    /// <summary>
    /// Fusion holds the text as a Lua string, so quotes and newlines have to be tamed.
    /// </summary>
    private static string LuaEscape(string text)
    {
        return text
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\r", string.Empty)
            .Replace("\n", " ");
    }

    private static string RewriteBlob(string hex, Dictionary<string, string> replacements)
    {
        byte[] raw = Convert.FromHexString(hex);
        byte[] outer = Inflate(raw, 4);

        int innerAt = IndexOfInnerStream(outer);
        if (innerAt < 4)
            return hex;

        byte[] inner = Inflate(outer, innerAt);
        string innerText = Encoding.UTF8.GetString(inner);
        bool replaced = false;

        foreach (KeyValuePair<string, string> replacement in replacements)
        {
            string pattern = @"(StyledText\s*=\s*Input\s*\{\s*Value\s*=\s*"")" + Regex.Escape(replacement.Key) + @"("")";
            if (!Regex.IsMatch(innerText, pattern))
                continue;

            string value = LuaEscape(replacement.Value).Replace("$", "$$");
            innerText = Regex.Replace(innerText, pattern, "${1}" + value + "${2}");
            replaced = true;
        }

        if (!replaced)
            return hex;

        byte[] newInner = Encoding.UTF8.GetBytes(innerText);

        using MemoryStream rebuilt = new();
        rebuilt.Write(outer, 0, innerAt - 4);
        rebuilt.Write(BitConverter.GetBytes(newInner.Length));
        rebuilt.Write(Deflate(newInner));

        byte[] newOuter = rebuilt.ToArray();
        WriteDataLength(newOuter);

        byte[] lengthPrefix = BitConverter.GetBytes(newOuter.Length);
        Array.Reverse(lengthPrefix);

        return Convert.ToHexString(lengthPrefix.Concat(Deflate(newOuter)).ToArray()).ToLowerInvariant();
    }

    private static void RewriteCompositions(string xmlFile, Dictionary<string, string> replacements)
    {
        string xml = File.ReadAllText(xmlFile);
        if (!xml.Contains("<CompositionBA>"))
            return;

        xml = Regex.Replace(xml, "<CompositionBA>([0-9a-fA-F]+)</CompositionBA>",
            match => "<CompositionBA>" + RewriteBlob(match.Groups[1].Value, replacements) + "</CompositionBA>");

        File.WriteAllText(xmlFile, xml);
    }

    private static void RewriteProjectName(string workingFolder, string projectName)
    {
        string projectXml = Path.Combine(workingFolder, "project.xml");
        if (!File.Exists(projectXml))
            return;

        string xml = File.ReadAllText(projectXml);

        xml = Regex.Replace(xml, "<ProjectName>[^<]*</ProjectName>", "<ProjectName>" + projectName + "</ProjectName>");
        xml = Regex.Replace(xml, @"<Name>[^<]*\.Cfg</Name>", "<Name>" + projectName + ".Cfg</Name>");

        File.WriteAllText(projectXml, xml);
    }

    /// <summary>
    /// The composition sits in a "data" field that records its own size, big endian,
    /// in the four bytes immediately before it.
    /// </summary>
    private static void WriteDataLength(byte[] outer)
    {
        int compositionAt = Encoding.ASCII.GetString(outer).IndexOf(CompositionMarker, StringComparison.Ordinal);
        if (compositionAt < 4)
            return;

        int dataLength = outer.Length - compositionAt;

        outer[compositionAt - 4] = (byte)(dataLength >> 24);
        outer[compositionAt - 3] = (byte)(dataLength >> 16);
        outer[compositionAt - 2] = (byte)(dataLength >> 8);
        outer[compositionAt - 1] = (byte)dataLength;
    }
}
