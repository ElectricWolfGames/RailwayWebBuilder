using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;

namespace RailwayWebBuilderCore._Site.Railways.GCR
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    internal class Auction : PageDetails
    {
        public Auction()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Auction";
            MenuTitle = "Auction";
            DontShowNavigation = true;
        }

        public static string CreateHero(PageDetails pageDetails)
        {
            HTMLBuilder pageBuilder = new();
            pageBuilder.Jumbotron(pageDetails.DisplayTitle, string.Empty);
            return pageBuilder.Output();
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");
            WebPage.Append("</br>");
            WebPage.Append(LocoRef.CreateHero(this));

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }
    }
}