using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Stations.GCR_A60Bridge;
using RailwayWebBuilderCore._Site.Railways.Stations.GCR_LeicestershireNorth;
using RailwayWebBuilderCore._Site.Railways.Stations.GCR_LoughboroughStation;
using RailwayWebBuilderCore._Site.Railways.Stations.GCR_QuornAndWoodHouse;
using RailwayWebBuilderCore._Site.Railways.Stations.GCR_Rothley;
using RailwayWebBuilderCore._Site.Railways.Stations.GCR_RushcliffeHalt;
using RailwayWebBuilderCore._Site.Railways.Stations.Mainline_LoughboroughStation;
using RailwayWebBuilderCore.Interfaces;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.Stations
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class Stations : PageDetails
    {
        public Stations()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Stations";
            MenuTitle = "Stations";
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

            WebPage.Append("<div class='row mb-2'>");
            WebPage.Append(AddA60Bridge());
            WebPage.Append(AddLeicestershireNorthPage());
            WebPage.Append(AddLoughboroughStation());
            WebPage.Append(AddQuornAndWoodHouse());
            WebPage.Append(AddStationRothley());
            WebPage.Append(AddStationRushcliffeHalt());
            WebPage.Append(AddMainlineLoughboroughStation());

            WebPage.Append("</div>");
            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string AddA60Bridge()
        {
            IStationsPages stationsPages = new GCR_A60BridgePage();
            string htmlPath = $@"GCR-A60Bridge\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string AddLeicestershireNorthPage()
        {
            IStationsPages stationsPages = new GCR_LeicestershireNorthPage();
            string htmlPath = $@"GCR-LeicestershireNorth\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string AddLoughboroughStation()
        {
            IStationsPages stationsPages = new GCR_LoughboroughStationPage();
            string htmlPath = $@"GCR-LoughboroughStation\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string AddMainlineLoughboroughStation()
        {
            IStationsPages stationsPages = new Mainline_LoughboroughStationPage();
            string htmlPath = $@"Mainline-LoughboroughStation\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string AddQuornAndWoodHouse()
        {
            IStationsPages stationsPages = new GCR_QuornAndWoodHousePage();
            string htmlPath = $@"GCR-QuornAndWoodHouse\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string AddStationRothley()
        {
            IStationsPages stationsPages = new GCR_RothleyPage();
            string htmlPath = $@"GCR-Rothley\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string AddStationRushcliffeHalt()
        {
            IStationsPages stationsPages = new GCR_RushcliffeHaltPage();
            string htmlPath = $@"GCR-RushcliffeHalt\index.html";
            return CreateCard(stationsPages, htmlPath);
        }

        private static string CreateCard(IStationsPages stationsPages, string path)
        {
            StringBuilder blogHtml = new StringBuilder();

            blogHtml.AppendLine("<div class='col-md-6'>");
            blogHtml.AppendLine("<div class='card border-dark mb-3'>");
            blogHtml.AppendLine($"<h5 class='card-header'>{stationsPages.StationLocations.Name}</h5>");
            blogHtml.AppendLine("<div class='card-body'>");
            blogHtml.AppendLine($"      <img class='rounded float-right' width='214px' height ='160px'src='{stationsPages.HilightImage}'>");
            blogHtml.AppendLine($"<p class='col-md-6 card-text float-left'>{stationsPages.StationLocations.Address}</p>");
            blogHtml.AppendLine($"<p class='col-md-6 '><a href='{path}' class='font-weight-bold'>See more</a></p>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");
            blogHtml.AppendLine("</div>");

            return blogHtml.ToString();
        }
    }
}