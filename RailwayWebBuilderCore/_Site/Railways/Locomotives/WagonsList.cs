using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Enums;

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
            WebPage.Append(LocoRef.CreateStockList(StockTypes.Wagon));

            WebPage.Append("</div>");

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }
    }
}