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

namespace RailwayWebBuilderCore._Site.Railways.Locomotives
{
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

            if (pageDetails.MenuTitle.Contains("Steam"))
                pageBuilder.Text($"<a href='{offSet}SteamList.html' class='btn btn-info btn-lg'><h1>Steam</h1></a>");
            else
                pageBuilder.Text($"<a href='{offSet}SteamList.html' class='btn btn-primary btn-lg'><h1>Steam</h1></a>");

            if (pageDetails.MenuTitle.Contains("Diesel"))
                pageBuilder.Text($"<a href='{offSet}DieselList.html' class='btn btn-info btn-lg'><h1>Diesel</h1></a>");
            else
                pageBuilder.Text($"<a href='{offSet}DieselList.html' class='btn btn-primary btn-lg'><h1>Diesel</h1></a>");

            if (pageDetails.MenuTitle.Contains("Wagon"))
                pageBuilder.Text($"<a href='{offSet}WagonsList.html' class='btn btn-info btn-lg'><h1>Wagons</h1></a>");
            else
                pageBuilder.Text($"<a href='{offSet}WagonsList.html' class='btn btn-primary btn-lg'><h1>Wagons</h1></a>");

            if (pageDetails.MenuTitle.Contains("Coach"))
                pageBuilder.Text($"<a href='{offSet}CoachesList.html' class='btn btn-info btn-lg'><h1>Coaches</h1></a>");
            else
                pageBuilder.Text($"<a href='{offSet}CoachesList.html' class='btn btn-primary btn-lg'><h1>Coaches</h1></a>");

            pageBuilder.NewLine();
            pageBuilder.NewLine();

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
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

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
}