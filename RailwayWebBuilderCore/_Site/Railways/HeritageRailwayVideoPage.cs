using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.HeritageRailways;

[PageTitle("HeritageRailwayVideoPlaceholder.html")]
[Navigation(NavigationTypes.Main, 2)]
public class HeritageRailwayVideoPage : PageDetails
{
    public HeritageRailwayVisit Visit { get; set; }

    public HeritageRailwayVideoPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Heritage Railway";
        MenuTitle = "Heritage Railway";
        DontShowNavigation = true;
        DontBuildPage = true;
    }

    public override void CreatePage()
    {
        DisplayTitle = Visit.Title;
        MenuTitle = Visit.Title;

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");

        // Breadcrumb
        WebPage.Append(@"<nav aria-label='breadcrumb' class='mb-3'>
  <ol class='breadcrumb'>
    <li class='breadcrumb-item'><a href='HeritageRailways.html'>Heritage Railways</a></li>
    <li class='breadcrumb-item active'>" + Visit.Title + @"</li>
  </ol>
</nav>");

        // Title block
        WebPage.Append($"<h2>{Visit.Title}</h2>");

        if (!string.IsNullOrEmpty(Visit.RailwayName) && Visit.RailwayName != "–")
            WebPage.Append($"<p class='text-muted mb-1'><strong>{Visit.RailwayName}</strong></p>");

        if (!string.IsNullOrEmpty(Visit.Location) && Visit.Location != "–")
            WebPage.Append($"<p class='text-muted small mb-2'>&#128205; {Visit.Location}</p>");

        if (!string.IsNullOrEmpty(Visit.VisitDate))
            WebPage.Append($"<p class='text-muted small mb-3'>&#128197; {Visit.VisitDate} &nbsp;&#9201; {Visit.Duration}</p>");

        // Tags
        if (Visit.Tags.Count > 0)
        {
            var tagHtml = new StringBuilder();
            tagHtml.Append("<div class='mb-3'>");
            foreach (var tag in Visit.Tags)
                tagHtml.Append($"<span class='badge badge-secondary mr-1'>{tag}</span>");
            tagHtml.Append("</div>");
            WebPage.Append(tagHtml.ToString());
        }

        // YouTube embed
        WebPage.Append($@"<div class='embed-responsive embed-responsive-16by9 mb-4'>
  <iframe class='embed-responsive-item' src='https://www.youtube.com/embed/{Visit.VideoId}'
    title='{Visit.Title}' frameborder='0'
    allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'
    allowfullscreen></iframe>
</div>");

        // Description
        if (!string.IsNullOrEmpty(Visit.Description))
        {
            WebPage.Append("<div class='card bg-light mb-4'><div class='card-body'>");
            WebPage.Append($"<p class='mb-0'>{Visit.Description}</p>");
            WebPage.Append("</div></div>");
        }

        // YouTube link
        WebPage.Append($@"<a href='https://www.youtube.com/watch?v={Visit.VideoId}' class='btn btn-danger mr-2' target='_blank'>&#9654; Watch on YouTube</a>");
        WebPage.Append(@"<a href='HeritageRailways.html' class='btn btn-outline-secondary'>&larr; Back to Heritage Railways</a>");

        WebPage.Append("</div>");

        WebPage.HtmlPath = Constants.HeritageRailways;
        WebPage.HtmlTitle = $"{Visit.VideoId}.html";
        WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways";
        WebPage.SetDontBuild = false;

        WebPage.EndBody();
        WebPage.Output();
    }
}
