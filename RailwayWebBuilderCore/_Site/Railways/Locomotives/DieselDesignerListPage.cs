using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("DieselDesigners.html")]
[Navigation(NavigationTypes.Main, 2)]
public class DieselDesignerListPage : PageDetails
{
    public DieselDesignerListPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Diesel Locomotive Designers";
        MenuTitle = "Diesel Designers";
        DontShowNavigation = true;
    }

    public override void CreatePage()
    {
        var allEntries = DieselClassEntry.BuildAll();

        var byDesigner = allEntries
            .Where(e => !string.IsNullOrEmpty(e.Designer))
            .GroupBy(e => e.Designer)
            .OrderBy(g => g.Key)
            .ToList();

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));

        WebPage.Append("<p class='lead mb-4'>The principal designers behind British diesel and electric locomotives.</p>");
        WebPage.Append("<div class='row'>");

        foreach (var group in byDesigner)
        {
            string slug = DesignerListPage.ToSlug(group.Key);
            int inCollection = group.Count(e => !string.IsNullOrEmpty(e.FirstLocoNumber));
            string collBadge = inCollection > 0
                ? $"<span class='badge badge-success ml-1'>{inCollection} in collection</span>"
                : "";

            var powerTypes = group.Select(e => e.PowerType).Where(p => !string.IsNullOrEmpty(p)).Distinct();
            string powerSummary = string.Join(", ", powerTypes);

            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100'>
    <div class='card-body'>
      <h6 class='card-title mb-1'><a href='DieselDesigners/{slug}.html'>{group.Key}</a>{collBadge}</h6>
      <p class='text-muted small mb-1'>{group.Count()} class(es)</p>
      {(string.IsNullOrEmpty(powerSummary) ? "" : $"<p class='text-muted small mb-0'>{powerSummary}</p>")}
    </div>
  </div>
</div>");
        }

        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        // Generate detail pages
        foreach (var group in byDesigner)
        {
            var page = new DieselReferencePageDetails
            {
                RefTitle = group.Key,
                CategoryLabel = "Diesel Designer",
                Entries = group.ToList(),
                OutputSubPath = Constants.DieselDesigners,
                OutputSlug = $"{DesignerListPage.ToSlug(group.Key)}.html"
            };
            page.CreatePage();
        }
    }
}
