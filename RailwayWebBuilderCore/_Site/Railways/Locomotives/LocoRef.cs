using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives;

[PageTitle("LocoRef.html")]
[Navigation(NavigationTypes.Main, 2)]
public class LocoRef : PageDetails
{
    private static readonly Random _random = new();

    public LocoRef()
    {
        WebPage = new WebPage(this);
        DisplayTitle = "Locomotive Photo Reference Collection";
        MenuTitle = "Loco Photos";

        Keywords.AddRange(
            [
                "Model Railway",
                "model trains",
                "trains",
                "Hornby",
                "heritage railway",
            ]);
    }

    public static string CreateGroups(PageDetails pageDetails, string offSet)
    {
        HTMLBuilder pageBuilder = new();

        string steamActive = pageDetails.MenuTitle.Contains("Steam") ? "btn-primary" : "btn-outline-primary";
        string dieselActive = pageDetails.MenuTitle.Contains("Diesel") ? "btn-primary" : "btn-outline-primary";
        string wagonsActive = pageDetails.MenuTitle.Contains("Wagon") ? "btn-primary" : "btn-outline-primary";
        string coachActive = pageDetails.MenuTitle.Contains("Coach") ? "btn-primary" : "btn-outline-primary";

        pageBuilder.Text("<div class='d-flex flex-wrap mb-4'>");
        pageBuilder.Text($"<a href='{offSet}SteamList.html'   class='btn btn-lg {steamActive} flex-fill mx-1 mb-2'>Steam</a>");
        pageBuilder.Text($"<a href='{offSet}DieselList.html'  class='btn btn-lg {dieselActive} flex-fill mx-1 mb-2'>Diesel</a>");
        pageBuilder.Text($"<a href='{offSet}WagonsList.html'  class='btn btn-lg {wagonsActive} flex-fill mx-1 mb-2'>Wagons</a>");
        pageBuilder.Text($"<a href='{offSet}CoachesList.html' class='btn btn-lg {coachActive} flex-fill mx-1 mb-2'>Coaches</a>");
        pageBuilder.Text("</div>");

        return pageBuilder.Output();
    }

    public static string CreateTypePreview(StockTypes stockTypes, string title, string listHref, int count = 4)
    {
        var candidates = new List<(IDieselClass cls, ILocoDetails tag, List<string> images)>();
        foreach (var cls in GetLocoRefDetails(stockTypes))
        {
            foreach (var tag in cls.LocoNumbers)
            {
                var images = cls.GetAllImages(tag.Number, tag.Ignore);
                if (images.Any())
                    candidates.Add((cls, tag, images));
            }
        }

        if (!candidates.Any())
            return string.Empty;

        var picked = candidates.OrderBy(_ => _random.Next()).Take(count).ToList();

        HTMLBuilder pageBuilder = new();
        pageBuilder.Text("<div class='d-flex justify-content-between align-items-center mb-2'>");
        pageBuilder.Text($"<h5 class='mb-0'>{title}</h5>");
        pageBuilder.Text($"<a href='{listHref}' class='small'>View all &rarr;</a>");
        pageBuilder.Text("</div>");

        pageBuilder.Text("<div class='row mb-4'>");
        foreach (var (cls, tag, images) in picked)
        {
            string image = images.FirstOrDefault(x => x.Contains("Show")) ?? images.First();

            const string finalPath = "E:\\eWolfSiteUploads\\Railways\\Locomotives\\Ref\\images\\";
            (_, string newPathThumb) = HTMLHelper.CopyImageUploads(finalPath, image);
            newPathThumb = newPathThumb.Replace("E:\\eWolfSiteUploads\\Railways\\Locomotives\\", "");

            pageBuilder.Text($@"<div class='col-6 col-md-3 mb-3'>
  <a href='Ref/{tag.Number}.html' class='card h-100 shadow-sm text-decoration-none'>
    <img src='{newPathThumb}' class='card-img-top' alt='{cls.ClassName}' style='height:120px;object-fit:cover;'>
    <div class='card-body p-2'>
      <small class='text-muted d-block'>{cls.ClassName}</small>
      <span class='font-weight-bold'>{tag.Number}</span>
    </div>
  </a>
</div>");
        }
        pageBuilder.Text("</div>");

        return pageBuilder.Output();
    }

    public static string CreateHero(PageDetails pageDetails)
    {
        HTMLBuilder pageBuilder = new();
        pageBuilder.Jumbotron(pageDetails.DisplayTitle, string.Empty);
        return pageBuilder.Output();
    }

    public static string CreatelItemList(WebPage webPage, StockTypes stockTypes)
    {
        HTMLBuilder pageBuilder = new();
        var dieselList = GetLocoRefDetails(stockTypes);

        foreach (var dieselClass in dieselList)
        {
            HTMLBuilder pageBuilderTemp = new();
            string title = dieselClass.ClassName;
            if (!string.IsNullOrEmpty(dieselClass.ClassDisplayName))
                title = dieselClass.ClassDisplayName;
            pageBuilderTemp.Title(title);

            int count = dieselClass.PreviewLocos(pageBuilderTemp, webPage);
            if (count != 0)
            {
                pageBuilder.Text(pageBuilderTemp.Output());
            }
        }
        return pageBuilder.Output();
    }

    public override void CreatePage()
    {
        WebPage.AddHeader(this, string.Empty);
        WebPage.AddNavigation(NavigationTypes.Main, @"../../");
        WebPage.StartBody();

        WebPage.Append("<div class='container mt-4'>");

        WebPage.Append("</br>");
        WebPage.Append(CreateHero(this));
        WebPage.Append(CreateGroups(this, ""));

        WebPage.Append(CreateTypePreview(StockTypes.SteamLoco, "Steam", "SteamList.html"));
        WebPage.Append(CreateTypePreview(StockTypes.Diesel, "Diesel", "DieselList.html"));
        WebPage.Append(CreateTypePreview(StockTypes.Wagon, "Wagons", "WagonsList.html"));
        WebPage.Append(CreateTypePreview(StockTypes.Coach, "Coaches", "CoachesList.html"));

        WebPage.Append(GoogleAdsHelper.AdsBanner);

        WebPage.Append("</div>");

        WebPage.EndBody();
        WebPage.Output();
    }

    internal static string[] GetKeywords(StockTypes stockTypes)
    {
        var locoDetals = from t in Assembly.GetExecutingAssembly().GetTypes()
                         where t.GetInterfaces().Contains(typeof(IDieselClass))
                               && t.GetConstructor(Type.EmptyTypes) != null
                         select Activator.CreateInstance(t) as IDieselClass;

        locoDetals = locoDetals.Where(x => x.StockType == stockTypes);
        return locoDetals.Select(x => x.ClassName).ToArray();
    }

    private static IEnumerable<IDieselClass> GetLocoRefDetails(StockTypes stockTypes)
    {
        var locoDetals = from t in Assembly.GetExecutingAssembly().GetTypes()
                         where t.GetInterfaces().Contains(typeof(IDieselClass))
                               && t.GetConstructor(Type.EmptyTypes) != null
                         select Activator.CreateInstance(t) as IDieselClass;

        locoDetals = locoDetals.Where(x => x.StockType == stockTypes);
        return locoDetals;
    }
}