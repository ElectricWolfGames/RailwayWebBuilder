using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using System.Linq;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("DieselWheelArrangements.html")]
[Navigation(NavigationTypes.Main, 2)]
public class DieselWheelArrangementListPage : PageDetails
{
    public DieselWheelArrangementListPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Diesel Wheel Arrangements";
        MenuTitle = "Diesel Wheel Arrangements";
        DontShowNavigation = true;
    }

    public override void CreatePage()
    {
        var allEntries = DieselClassEntry.BuildAll();

        var byWheel = allEntries
            .Where(e => !string.IsNullOrEmpty(e.WheelArrangement))
            .GroupBy(e => e.WheelArrangement)
            .OrderBy(g => g.Key)
            .ToList();

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));

        WebPage.Append("<p class='lead mb-4'>Diesel and electric locomotive wheel arrangements used on British railways.</p>");
        WebPage.Append("<div class='row'>");

        foreach (var group in byWheel)
        {
            string slug = DesignerListPage.ToSlug(group.Key);
            int inCollection = group.Count(e => !string.IsNullOrEmpty(e.FirstLocoNumber));
            string collBadge = inCollection > 0
                ? $"<span class='badge badge-success ml-1'>{inCollection} in collection</span>"
                : "";

            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100'>
    <div class='card-body'>
      <h6 class='card-title mb-1'><a href='DieselWheelArrangements/{slug}.html'>{group.Key}</a>{collBadge}</h6>
      <p class='text-muted small mb-0'>{group.Count()} class(es)</p>
    </div>
  </div>
</div>");
        }

        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        foreach (var group in byWheel)
        {
            var page = new DieselReferencePageDetails
            {
                RefTitle = $"{group.Key} Wheel Arrangement",
                CategoryLabel = "Diesel Wheel Arrangement",
                Entries = group.ToList(),
                OutputSubPath = Constants.DieselWheelArrangements,
                OutputSlug = $"{DesignerListPage.ToSlug(group.Key)}.html"
            };
            page.CreatePage();
        }
    }
}
