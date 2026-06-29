using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("SteamReferencePlaceholder.html")]
[Navigation(NavigationTypes.Main, 2)]
public class SteamReferencePageDetails : PageDetails
{
    public string RefTitle { get; set; } = string.Empty;
    public string CategoryLabel { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<SteamLocoEntry> Entries { get; set; } = new();
    public Dictionary<string, string> CollectionLookup { get; set; } = new();
    public string OutputSubPath { get; set; } = string.Empty;
    public string OutputSlug { get; set; } = string.Empty;

    public SteamReferencePageDetails()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Steam Reference";
        MenuTitle = "Steam Reference";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public override void CreatePage()
    {
        DisplayTitle = RefTitle;
        MenuTitle = RefTitle;

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, "../"));

        if (!string.IsNullOrEmpty(Description))
        {
            WebPage.Append("<div class='card bg-light mb-4'><div class='card-body'>");
            if (!string.IsNullOrEmpty(CategoryLabel))
                WebPage.Append($"<h5 class='text-muted mb-2'>{CategoryLabel}</h5>");
            WebPage.Append($"<p class='mb-0'>{Description}</p>");
            WebPage.Append("</div></div>");
        }

        WebPage.Append(BuildLocosGrid());

        WebPage.Append("</div>");

        WebPage.HtmlPath = OutputSubPath;
        WebPage.HtmlTitle = OutputSlug;
        WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways";
        WebPage.SetDontBuild = false;

        WebPage.EndBody();
        WebPage.Output();
    }

    private string BuildLocosGrid()
    {
        var sb = new StringBuilder();
        sb.AppendLine("<div class='row'>");

        foreach (var entry in Entries.OrderBy(e => e.ClassName))
        {
            CollectionLookup.TryGetValue(entry.CollectionKey.Trim(), out string locoNumber);
            bool inCollection = !string.IsNullOrEmpty(entry.CollectionKey) && !string.IsNullOrEmpty(locoNumber);

            var metaParts = new List<string>();
            if (!string.IsNullOrEmpty(entry.WhyteNotation)) metaParts.Add(entry.WhyteNotation);
            if (!string.IsNullOrEmpty(entry.BuildDate)) metaParts.Add(entry.BuildDate);
            if (entry.TotalProduced > 0) metaParts.Add($"{entry.TotalProduced} built");
            string meta = string.Join(" · ", metaParts);

            sb.AppendLine("<div class='col-md-4 mb-3'>");
            sb.AppendLine("<div class='card h-100'>");
            sb.AppendLine("<div class='card-body d-flex flex-column'>");

            string badge = inCollection ? "<span class='badge badge-success float-right'>In Collection</span>" : "";
            sb.AppendLine($"<h6 class='card-title'>{entry.ClassName} {badge}</h6>");

            if (!string.IsNullOrEmpty(meta))
                sb.AppendLine($"<p class='text-muted small mb-1'>{meta}</p>");

            if (!string.IsNullOrEmpty(entry.Description))
                sb.AppendLine($"<p class='card-text small flex-grow-1'>{entry.Description}</p>");

            if (inCollection)
                sb.AppendLine($"<a href='../Ref/{locoNumber}.html' class='btn btn-sm btn-outline-primary mt-2 align-self-start'>View in Collection &rarr;</a>");

            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
        }

        sb.AppendLine("</div>");
        return sb.ToString();
    }
}
