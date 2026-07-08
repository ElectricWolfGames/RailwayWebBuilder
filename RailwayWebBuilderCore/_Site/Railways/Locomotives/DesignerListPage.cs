using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore._SiteData.LocoRefs;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("LocoDesigners.html")]
[Navigation(NavigationTypes.Main, 2)]
public class DesignerListPage : PageDetails
{
    public DesignerListPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Locomotive Designers";
        MenuTitle = "Loco Designers";
        DontShowNavigation = true;
    }

    public override void CreatePage()
    {
        var collectionLookup = BuildCollectionLookup();

        // Loco entries keyed by designer name for detail pages
        var locosByDesigner = UKSteamLocomotiveData.AllLocos
            .GroupBy(e => e.Designer)
            .ToDictionary(g => g.Key, g => g.ToList());

        // Designers sorted chronologically
        var designers = UKSteamLocomotiveData.AllDesigners
            .OrderBy(d => d.ActiveFrom)
            .ToList();

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));

        WebPage.Append(BuildColourKey());

        WebPage.Append("<p class='lead mb-4'>The Chief Mechanical Engineers and Locomotive Superintendents who shaped British steam — listed in chronological order of appointment.</p>");
        WebPage.Append("<div class='row'>");

        foreach (var designer in designers)
        {
            string color = GetRailwayColor(designer.RailwayCode);
            string slug = ToSlug(designer.Name);

            locosByDesigner.TryGetValue(designer.Name, out var entries);
            int collectionCount = entries?.Count(e => !string.IsNullOrEmpty(e.CollectionKey)) ?? 0;
            string collBadge = collectionCount > 0
                ? $"<span class='badge badge-light ml-1' style='color:{color}'>{collectionCount} in collection</span>"
                : "";

            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100' style='border-top: 4px solid {color}'>
    <div class='card-body'>
      <div class='d-flex justify-content-between align-items-start mb-1'>
        <h6 class='card-title mb-0'><a href='Designers/{slug}.html'>{designer.Name}</a></h6>
        <span class='badge' style='background-color:{color};color:#fff;white-space:nowrap'>{designer.RailwayCode}</span>
      </div>
      <p class='text-muted small mb-1'>{designer.ActiveFrom}–{designer.ActiveTo}</p>
      <p class='text-muted small mb-1'>{designer.RailwayName}</p>
      <p class='text-muted small mb-0'><em>{designer.Role}</em>{collBadge}</p>
    </div>
  </div>
</div>");
        }

        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        // Generate individual designer detail pages
        foreach (var designer in designers)
        {
            locosByDesigner.TryGetValue(designer.Name, out var entries);
            UKSteamLocomotiveData.DesignerBios.TryGetValue(designer.Name, out string bio);

            var page = new SteamReferencePageDetails
            {
                RefTitle = designer.Name,
                CategoryLabel = $"{designer.Role} · {designer.RailwayName} · {designer.ActiveFrom}–{designer.ActiveTo}",
                Description = bio ?? string.Empty,
                Entries = entries ?? new List<SteamLocoEntry>(),
                CollectionLookup = collectionLookup,
                OutputSubPath = Constants.LocoDesigners,
                OutputSlug = $"{ToSlug(designer.Name)}.html"
            };
            page.CreatePage();
        }
    }

    internal static Dictionary<string, string> BuildCollectionLookup()
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var type in Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsSubclassOf(typeof(SteamClassBase)) && !t.IsAbstract))
        {
            try
            {
                var sc = (SteamClassBase)Activator.CreateInstance(type);
                if (sc.LocoNumbers.Count > 0)
                    result[sc.ClassName.Trim()] = sc.LocoNumbers[0].Number;
            }
            catch { }
        }
        return result;
    }

    internal static string GetRailwayColor(string code)
    {
        UKSteamLocomotiveData.RailwayColors.TryGetValue(code, out string color);
        return color ?? "#6c757d";
    }

    internal static string ToSlug(string value)
    {
        var s = Regex.Replace(value.ToLowerInvariant(), @"[^a-z0-9]", "-");
        return Regex.Replace(s, @"-+", "-").Trim('-');
    }

    private static string BuildColourKey()
    {
        // Group designers by railway code, keeping order of first appearance
        var seen = new HashSet<string>();
        var railways = UKSteamLocomotiveData.AllDesigners
            .OrderBy(d => d.ActiveFrom)
            .Select(d => (d.RailwayCode, d.RailwayName))
            .Where(r => seen.Add(r.RailwayCode))
            .ToList();

        var sb = new System.Text.StringBuilder();
        sb.AppendLine("<div class='mb-3 d-flex flex-wrap align-items-center'>");
        sb.AppendLine("<small class='text-muted mr-2 mb-1'>Colour key:</small>");
        foreach (var (code, name) in railways)
        {
            string color = GetRailwayColor(code);
            sb.AppendLine($"<span class='badge mr-1 mb-1' style='background-color:{color};color:#fff' title='{name}'>{code}</span>");
        }
        sb.AppendLine("</div>");
        return sb.ToString();
    }
}