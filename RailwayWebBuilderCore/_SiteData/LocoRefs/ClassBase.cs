using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Path = System.IO.Path;

namespace RailwayWebBuilderCore._SiteData.LocoRefs;

public class ClassBase : IDieselClass, ITypeAndOrigin
{
    private const string LookInFolders = "E:\\Trains\\Photos - Main\\2025\\";
    public string BuildDate { get; set; } = string.Empty;
    public string Builder { get; set; } = string.Empty;
    public string ClassDisplayName { get; set; }
    public string ClassName { get; set; }
    public List<string> Keywords { get; private set; } = new List<string>();
    public List<ILocoDetails> LocoNumbers { get; set; } = new List<ILocoDetails>();
    public string Overview { get; set; } = "";
    public string Paragraph1 { get; set; } = "";
    public string Paragraph2 { get; set; } = "";
    public string Paragraph3 { get; set; } = string.Empty;
    public string PowerType { get; set; } = string.Empty;
    public StockTypes StockType { get; set; } = StockTypes.Diesel;
    public int TotalProduced { get; set; } = 0;

    public string WikiLink { get; set; }

    public List<string> GetAllImages(string tag, List<string> ignore)
    {
        if (tag == "48305")
        {
            int i = 0;
            i++;
        }
        UpdateImageStock(tag, ignore);

        string rawPath = GetRawImagePath(tag);
        List<string> images = ImageHelper.GetAllImages(rawPath);

        return images;
    }

    public virtual string GetRawImagePath(string locoNo)
    {
        return Constants.RawDataPath + @$"\Locos\_Diesel\{ClassName.Replace(" ", "")}-{locoNo}\";
    }

    public int PreviewLocos(HTMLBuilder pageBuilder, WebPage webPage)
    {
        int count = 0;
        pageBuilder.Text("<div class='row'>");
        foreach (var tag in LocoNumbers)
        {
            var images = GetAllImages(tag.Number, tag.Ignore);
            count += images.Count();

            if (!images.Any())
                continue;

            string image = images.First();
            var showImages = images.Where(x => x.Contains("Show"));
            if (showImages.Any())
                image = showImages.First();

            string finalPath = "E:\\eWolfSiteUploads\\Railways\\Locomotives\\Ref\\images\\";
            (string newPath, string newPathThumb) = HTMLHelper.CopyImageUploads(finalPath, image);

            var filename = Path.GetFileName(newPath);
            CreateLocorefPage(tag.Number, this, webPage);

            newPathThumb = newPathThumb.Replace("E:\\eWolfSiteUploads\\Railways\\Locomotives\\", "");

            pageBuilder.Text(CreateCard(newPathThumb, "Ref\\", tag.Number));
        }
        pageBuilder.Text("</div>");
        return count;
    }

    private static string CreateCard(string imagePath, string path, string locoNumber)
    {
        StringBuilder blogHtml = new();

        path += $"{locoNumber}.html";

        blogHtml.AppendLine("<div class='col-md-4'>");
        blogHtml.AppendLine("<div class='card border-dark mb-3'>");
        blogHtml.AppendLine($"<h5 class='card-header'>{locoNumber}</h5>");
        blogHtml.AppendLine("<div class='card-body'>");
        blogHtml.AppendLine($"      <a href='{path}'><img class='rounded float-right' width='214px' height ='160px'src='{imagePath}'></a>");
        blogHtml.AppendLine($"<p class='col-md-4 card-text float-left'></p>");
        //            blogHtml.AppendLine($"<p class='col-md-2 '><a href='{path}' class='font-weight-bold'>See more</a></p>");
        blogHtml.AppendLine("</div>");
        blogHtml.AppendLine("</div>");
        blogHtml.AppendLine("</div>");

        return blogHtml.ToString();
    }

    private void CreateLocorefPage(string number, ClassBase dieselClassBase, WebPage webPage)
    {
        LocoRefPageDetails pageDetails = new();
        pageDetails.DieselClassBase = dieselClassBase;
        pageDetails.MenuTitle = number;
        pageDetails.LocoNumber = number;
        pageDetails.WebPage.HtmlPath = webPage.HtmlPath + "\\Ref";
        pageDetails.GalleryPath = GetRawImagePath(number);
        pageDetails.CreatePage();
    }

    private void UpdateImageStock(string tag, List<string> ignore)
    {
        if (string.IsNullOrWhiteSpace(tag))
            return;

        string rawPath = GetRawImagePath(tag);

        /*
         * if (ignore.Any())
        {
            List<string> toRemove = new List<string>();
            foreach (var ignoreTemp in ignore)
            {
                if (string.IsNullOrEmpty(ignoreTemp))
                    continue;

                foreach (var imageTemp in files)
                {
                    if (imageTemp.Contains(ignoreTemp))
                    {
                        toRemove.Add(imageTemp);
                    }
                }
            }
            files = files.Except(toRemove).ToList();
        }
         */

        var filesOnDrive = Directory.GetFiles(LookInFolders, $"*{tag}*.JPG", SearchOption.AllDirectories);
        foreach (string file in filesOnDrive)
        {
            bool skip = false;
            if (file.ToLower().Contains("edit"))
            {
                continue;
            }

            string newPath = $"{rawPath}\\{Path.GetFileName(file)}";

            foreach (var ignoreTemp in ignore)
            {
                if (!string.IsNullOrWhiteSpace(ignoreTemp))
                {
                    if (file.Contains(ignoreTemp))
                    {
                        skip = true;
                    }
                }
            }

            if (skip)
            {
                continue;
            }

            if (!File.Exists(newPath))
            {
                Directory.CreateDirectory(rawPath);
                File.Copy(file, newPath);
            }
        }
    }
}