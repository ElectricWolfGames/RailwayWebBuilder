using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives
{
    [PageTitle("DieselList.html")]
    [Navigation(NavigationTypes.Main, 2)]
    public class DieselList : PageDetails
    {
        public DieselList()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Locomotive Photo Reference Collection";
            MenuTitle = "DieselList";
            DontShowNavigation = true;

            Keywords.AddRange(LocoRef.GetKeywords(StockTypes.Diesel));
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
            WebPage.Append(LocoRef.CreateStockList(StockTypes.Diesel));

            WebPage.Append("</div>");

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }
    }
}