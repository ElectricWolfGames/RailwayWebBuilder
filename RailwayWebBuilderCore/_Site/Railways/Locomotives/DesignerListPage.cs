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
        var byDesigner = UKSteamLocomotiveData.AllLocos
            .GroupBy(e => e.Designer)
            .OrderBy(g => g.Key)
            .ToList();

        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();
        WebPage.Append("<div class='container mt-4'>");
        WebPage.Append(LocoRef.CreateHero(this));
        WebPage.Append(LocoRef.CreateGroups(this, ""));
        WebPage.Append("<p class='lead mb-4'>The engineers who designed British steam locomotives — click a name to browse their complete class catalogue.</p>");
        WebPage.Append("<div class='row'>");
        foreach (var group in byDesigner)
        {
            int collectionCount = group.Count(e => !string.IsNullOrEmpty(e.CollectionKey));
            string slug = ToSlug(group.Key);
            string badge = collectionCount > 0 ? $"<span class='badge badge-primary ml-1'>{collectionCount} in collection</span>" : "";
            WebPage.Append($@"<div class='col-md-3 mb-3'>
  <div class='card h-100'>
    <div class='card-body'>
      <h6 class='card-title'><a href='Designers/{slug}.html'>{group.Key}</a> {badge}</h6>
      <p class='card-text text-muted small'>{group.Count()} classes listed</p>
    </div>
  </div>
</div>");
        }
        WebPage.Append("</div>");
        WebPage.Append("</div>");
        WebPage.EndBody();
        WebPage.Output();

        foreach (var group in byDesigner)
        {
            UKSteamLocomotiveData.DesignerBios.TryGetValue(group.Key, out string bio);
            var page = new SteamReferencePageDetails
            {
                RefTitle = group.Key,
                CategoryLabel = "Locomotive Designer",
                Description = bio ?? string.Empty,
                Entries = group.ToList(),
                CollectionLookup = collectionLookup,
                OutputSubPath = Constants.LocoDesigners,
                OutputSlug = $"{ToSlug(group.Key)}.html"
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

    internal static string ToSlug(string value)
    {
        var s = Regex.Replace(value.ToLowerInvariant(), @"[^a-z0-9]", "-");
        return Regex.Replace(s, @"-+", "-").Trim('-');
    }
}
