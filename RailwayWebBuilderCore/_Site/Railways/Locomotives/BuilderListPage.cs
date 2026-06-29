using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using System.Linq;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("LocoBuilders.html")]
[Navigation(NavigationTypes.Main, 2)]
public class BuilderListPage : PageDetails
{
    public BuilderListPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Locomotive Builders";
        MenuTitle = "Loco Builders";
        DontShowNavigation = true;
    }

    public override void CreatePage()
    {
        var collectionLookup = DesignerListPage.BuildCollectionLookup();
        var byBuilder = UKSteamLocomotiveData.AllLocos
            .GroupBy(e => e.PrimaryBuilder)
            .OrderBy(g => g.Key)
            .ToList();

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));
        WebPage.Append("<p class='lead mb-4'>Explore British steam locomotives by the works or manufacturer that built them — click a name to see their output.</p>");
        WebPage.Append("<div class='row'>");
        foreach (var group in byBuilder)
        {
            int collectionCount = group.Count(e => !string.IsNullOrEmpty(e.CollectionKey));
            string slug = DesignerListPage.ToSlug(group.Key);
            string badge = collectionCount > 0 ? $"<span class='badge badge-primary ml-1'>{collectionCount} in collection</span>" : "";
            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100'>
    <div class='card-body'>
      <h6 class='card-title'><a href='Builders/{slug}.html'>{group.Key}</a> {badge}</h6>
      <p class='card-text text-muted small'>{group.Count()} classes listed</p>
    </div>
  </div>
</div>");
        }
        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        foreach (var group in byBuilder)
        {
            UKSteamLocomotiveData.BuilderDescriptions.TryGetValue(group.Key, out string desc);
            var page = new SteamReferencePageDetails
            {
                RefTitle = group.Key,
                CategoryLabel = "Locomotive Builder",
                Description = desc ?? string.Empty,
                Entries = group.ToList(),
                CollectionLookup = collectionLookup,
                OutputSubPath = Constants.LocoBuilders,
                OutputSlug = $"{DesignerListPage.ToSlug(group.Key)}.html"
            };
            page.CreatePage();
        }
    }
}
