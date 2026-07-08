using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("DieselReferencePlaceholder.html")]
[Navigation(NavigationTypes.Main, 2)]
public class DieselReferencePageDetails : PageDetails
{
    public DieselReferencePageDetails()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Diesel Reference";
        MenuTitle = "Diesel Reference";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public string CategoryLabel { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<DieselClassEntry> Entries { get; set; } = new();
    public string OutputSlug { get; set; } = string.Empty;
    public string OutputSubPath { get; set; } = string.Empty;
    public string RefTitle { get; set; } = string.Empty;

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
            bool inCollection = !string.IsNullOrEmpty(entry.FirstLocoNumber);

            var metaParts = new List<string>();
            if (!string.IsNullOrEmpty(entry.PowerType)) metaParts.Add(entry.PowerType);
            if (!string.IsNullOrEmpty(entry.BuildDate)) metaParts.Add(entry.BuildDate);
            if (entry.TotalProduced > 0) metaParts.Add($"{entry.TotalProduced} built");
            string meta = string.Join(" · ", metaParts);

            var specParts = new List<string>();
            if (!string.IsNullOrEmpty(entry.Power)) specParts.Add(entry.Power);
            if (!string.IsNullOrEmpty(entry.MaxSpeed)) specParts.Add(entry.MaxSpeed);
            string specs = string.Join(" · ", specParts);

            sb.AppendLine("<div class='col-md-4 mb-3'>");
            sb.AppendLine("<div class='card h-100'>");
            sb.AppendLine("<div class='card-body d-flex flex-column'>");

            string badge = inCollection ? "<span class='badge badge-success float-right'>In Collection</span>" : "";
            sb.AppendLine($"<h6 class='card-title'>{entry.ClassName} {badge}</h6>");

            if (!string.IsNullOrEmpty(meta))
                sb.AppendLine($"<p class='text-muted small mb-1'>{meta}</p>");

            if (!string.IsNullOrEmpty(entry.Engine))
                sb.AppendLine($"<p class='text-muted small mb-1'>{entry.Engine}</p>");

            if (!string.IsNullOrEmpty(specs))
                sb.AppendLine($"<p class='font-weight-bold small mb-1 flex-grow-1'>{specs}</p>");

            if (inCollection)
                sb.AppendLine($"<a href='../Ref/{entry.FirstLocoNumber}.html' class='btn btn-sm btn-outline-primary mt-2 align-self-start'>View in Collection &rarr;</a>");

            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
        }

        sb.AppendLine("</div>");
        return sb.ToString();
    }
}