using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using System.Linq;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("DieselMaxSpeeds.html")]
[Navigation(NavigationTypes.Main, 2)]
public class DieselMaxSpeedListPage : PageDetails
{
    public DieselMaxSpeedListPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Diesel Locomotives by Max Speed";
        MenuTitle = "Diesel Max Speeds";
        DontShowNavigation = true;
    }

    public override void CreatePage()
    {
        var allEntries = DieselClassEntry.BuildAll();

        var bySpeed = allEntries
            .Where(e => !string.IsNullOrEmpty(e.MaxSpeed))
            .GroupBy(e => e.MaxSpeed)
            .OrderBy(g => g.Key)
            .ToList();

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));

        WebPage.Append("<p class='lead mb-4'>British diesel and electric locomotive classes grouped by maximum speed.</p>");
        WebPage.Append("<div class='row'>");

        foreach (var group in bySpeed)
        {
            string slug = DesignerListPage.ToSlug(group.Key);
            int inCollection = group.Count(e => !string.IsNullOrEmpty(e.FirstLocoNumber));
            string collBadge = inCollection > 0
                ? $"<span class='badge badge-success ml-1'>{inCollection} in collection</span>"
                : "";

            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100'>
    <div class='card-body'>
      <h6 class='card-title mb-1'><a href='DieselMaxSpeeds/{slug}.html'>{group.Key}</a>{collBadge}</h6>
      <p class='text-muted small mb-0'>{group.Count()} class(es)</p>
    </div>
  </div>
</div>");
        }

        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        foreach (var group in bySpeed)
        {
            var page = new DieselReferencePageDetails
            {
                RefTitle = group.Key,
                CategoryLabel = "Maximum Speed",
                Entries = group.ToList(),
                OutputSubPath = Constants.DieselMaxSpeeds,
                OutputSlug = $"{DesignerListPage.ToSlug(group.Key)}.html"
            };
            page.CreatePage();
        }
    }
}
