using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
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
            MenuTitle = "LocoRef";

            Keywords.AddRange(
                new string[]
                {
                    "Model Railway",
                    "model trains",
                    "trains",
                    "Hornby",
                    "hertiage railway",
                });
        }

        public static string CreateGroups(PageDetails pageDetails, string offSet)
        {
            HTMLBuilder pageBuilder = new HTMLBuilder();

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
            HTMLBuilder pageBuilder = new HTMLBuilder();
            pageBuilder.Jumbotron(pageDetails.DisplayTitle, "");
            return pageBuilder.Output();
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append(CreateHero(this));
            WebPage.Append(CreateGroups(this, ""));

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        internal static string CreateStockList(StockTypes stockType)
        {
            var items = GetLocoRefDetails(stockType);

            HTMLBuilder pageBuilder = new HTMLBuilder();

            pageBuilder.Text("<h2></h2>");
            pageBuilder.Text("<us>");

            foreach (var loco in items)
            {
                AddLocoRef(pageBuilder, loco);
            }
            pageBuilder.Text("</us>");
            pageBuilder.Text("<br>");

            return pageBuilder.Output();
        }

        internal static string[] GetKeywords(StockTypes steamLoco)
        {
            List<ILocomotiveRefPage> locorefTypes;

            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(ILocomotiveRefPage))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as ILocomotiveRefPage;

            locorefTypes = layoutDetails.OrderBy(x => x.Title).ToList();
            locorefTypes = locorefTypes.OrderBy(x => x.Order).ToList();

            return locorefTypes.Select(x => x.Title).ToArray();
        }

        private static void AddLocoRef(HTMLBuilder pageBuilder, ILocomotiveRefPage loco)
        {
            if (loco.Title == null)
                return;

            loco.GrabImages();

            loco.Build();

            string href = $"<a href='Ref/{loco.PageTitle}.html'>{loco.Title}</a>";
            pageBuilder.Text($"<li>{href}</li>");
        }

        private static List<ILocomotiveRefPage> GetLocoRefDetails(StockTypes locoStockType)
        {
            List<ILocomotiveRefPage> locorefTypes;

            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(ILocomotiveRefPage))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as ILocomotiveRefPage;

            locorefTypes = layoutDetails.OrderBy(x => x.Title).ToList();
            locorefTypes = locorefTypes.OrderBy(x => x.Order).ToList();

            return locorefTypes.Where(x => x.StockType == locoStockType).ToList();
        }
    }
}