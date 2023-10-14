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
    [PageTitle("WagonsList.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class WagonsList : PageDetails
    {
        public WagonsList()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Locomotive Photo Reference Collection";
            MenuTitle = "WagonsList";
            DontShowNavigation = true;

            Keywords.AddRange(LocoRef.GetKeywords(StockTypes.Wagon));
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append(LocoRef.CreateHero(this));
            WebPage.Append(LocoRef.CreateGroups(this, ""));
            WebPage.Append(CreateDesselList());


            WebPage.Append("</div>");

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static IEnumerable<IDieselClass> GetLocoRefDetails()
        {
            var layoutDetails = from t in Assembly.GetExecutingAssembly().GetTypes()
                                where t.GetInterfaces().Contains(typeof(IDieselClass))
                                      && t.GetConstructor(Type.EmptyTypes) != null
                                select Activator.CreateInstance(t) as IDieselClass;

            layoutDetails = layoutDetails.Where(x => x.StockType == StockTypes.Wagon);
            return layoutDetails;
        }

        private string CreateDesselList()
        {
            HTMLBuilder pageBuilder = new HTMLBuilder();
            var dieselList = GetLocoRefDetails();

            foreach (var dieselClass in dieselList)
            {
                pageBuilder.Title(dieselClass.ClassName);
                dieselClass.PreviewLocos(pageBuilder, WebPage);
            }
            return pageBuilder.Output();
        }
    }
}