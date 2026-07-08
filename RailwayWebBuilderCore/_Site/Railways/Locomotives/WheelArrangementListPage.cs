using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("WheelArrangements.html")]
[Navigation(NavigationTypes.Main, 2)]
public class WheelArrangementListPage : PageDetails
{
    public WheelArrangementListPage()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Wheel Arrangements";
        MenuTitle = "Wheel Arrangements";
        DontShowNavigation = true;
    }

    public override void CreatePage()
    {
        var collectionLookup = DesignerListPage.BuildCollectionLookup();

        // Build a lookup of loco entries by wheel arrangement
        var locosByWhyte = UKSteamLocomotiveData.AllLocos
            .GroupBy(e => e.WhyteNotation)
            .ToDictionary(g => g.Key, g => g.ToList());

        // Merged descriptions: primary + supplementary
        var allDescriptions = new Dictionary<string, string>(UKSteamLocomotiveData.WheelArrangementDescriptions);
        foreach (var kvp in UKSteamLocomotiveData.ExtraWheelArrangementDescriptions)
        {
            if (!allDescriptions.ContainsKey(kvp.Key))
                allDescriptions[kvp.Key] = kvp.Value;
        }

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));
        WebPage.Append("<p class='lead mb-4'>Every Whyte wheel arrangement used on British steam locomotives — click an arrangement to browse UK classes that used it.</p>");

        WebPage.Append("<div class='row'>");
        foreach (var (notation, commonName) in UKSteamLocomotiveData.AllWheelArrangements)
        {
            locosByWhyte.TryGetValue(notation, out var entries);
            int collectionCount = entries?.Count(e => !string.IsNullOrEmpty(e.CollectionKey)) ?? 0;
            int totalCount = entries?.Count ?? 0;

            string slug = DesignerListPage.ToSlug(notation);
            string label = string.IsNullOrEmpty(commonName) ? notation : $"{notation} <small class='text-muted'>({commonName})</small>";
            string collBadge = collectionCount > 0 ? $"<span class='badge badge-primary ml-1'>{collectionCount} in collection</span>" : "";
            string countText = totalCount > 0 ? $"{totalCount} classes listed" : "Historical reference";

            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100'>
    <div class='card-body'>
      <h6 class='card-title'><a href='WheelArrangements/{slug}.html'>{label}</a> {collBadge}</h6>
      <p class='card-text text-muted small'>{countText}</p>
    </div>
  </div>
</div>");
        }
        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        foreach (var (notation, _) in UKSteamLocomotiveData.AllWheelArrangements)
        {
            locosByWhyte.TryGetValue(notation, out var entries);
            allDescriptions.TryGetValue(notation, out string desc);

            var page = new SteamReferencePageDetails
            {
                RefTitle = $"Wheel Arrangement: {notation}",
                CategoryLabel = "Whyte Notation",
                Description = desc ?? string.Empty,
                Entries = entries ?? new List<SteamLocoEntry>(),
                CollectionLookup = collectionLookup,
                OutputSubPath = Constants.LocoWheelArrangements,
                OutputSlug = $"{DesignerListPage.ToSlug(notation)}.html"
            };
            page.CreatePage();
        }
    }
}