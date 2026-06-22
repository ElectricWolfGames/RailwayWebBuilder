using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
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
                "hertiage railway",
            ]);
    }

    public static string CreateGroups(PageDetails pageDetails, string offSet)
    {
        HTMLBuilder pageBuilder = new();

        string steamActive  = pageDetails.MenuTitle.Contains("Steam")  ? " active" : "";
        string dieselActive = pageDetails.MenuTitle.Contains("Diesel") ? " active" : "";
        string wagonsActive = pageDetails.MenuTitle.Contains("Wagon")  ? " active" : "";
        string coachActive  = pageDetails.MenuTitle.Contains("Coach")  ? " active" : "";

        pageBuilder.Text("<ul class='nav nav-pills nav-fill mb-4'>");
        pageBuilder.Text($"<li class='nav-item'><a href='{offSet}SteamList.html'   class='nav-link{steamActive}'>Steam</a></li>");
        pageBuilder.Text($"<li class='nav-item'><a href='{offSet}DieselList.html'  class='nav-link{dieselActive}'>Diesel</a></li>");
        pageBuilder.Text($"<li class='nav-item'><a href='{offSet}WagonsList.html'  class='nav-link{wagonsActive}'>Wagons</a></li>");
        pageBuilder.Text($"<li class='nav-item'><a href='{offSet}CoachesList.html' class='nav-link{coachActive}'>Coaches</a></li>");
        pageBuilder.Text("</ul>");

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