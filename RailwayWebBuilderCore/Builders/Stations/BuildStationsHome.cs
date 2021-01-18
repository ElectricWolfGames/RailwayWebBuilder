using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsHome
    {
        public static void Build()
        {
            string localpath = Constants.RootPath + Constants.StationFolder;
            Directory.CreateDirectory(localpath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", localpath, new StationsHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Append(Jumbotron(null));
            pageBuilder.Append("<div class='row mb-2'>");

            AddStationLoughboroughStation(pageBuilder);
            AddBuildStationsQuornAndWoodHouse(pageBuilder);
            AddStationRothley(pageBuilder);
            AddStationLeicestershireNorth(pageBuilder);
            AddStationRushcliffeHalt(pageBuilder);

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLRailHelper.Modal());

            pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            pageBuilder.Output();
        }

        private static void AddStationLeicestershireNorth(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            IStationsPages stationsPages = new BuildStationsLeicestershireNorthPage();
            string htmlPath = $@"GCR-LeicestershireNorth\{stationsPages.HtmlFileName}";
            pageBuilder.Append(CreateCard(stationsPages, htmlPath));
        }

        private static void AddStationRothley(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            IStationsPages stationsPages = new BuildStationsRothleyPage();
            string htmlPath = $@"GCR-Rothley\{stationsPages.HtmlFileName}";
            pageBuilder.Append(CreateCard(stationsPages, htmlPath));
        }

        private static void AddStationRushcliffeHalt(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            IStationsPages stationsPages = new BuildStationsRushcliffeHaltPage();
            string htmlPath = $@"GCR-RushcliffeHalt\{stationsPages.HtmlFileName}";
            pageBuilder.Append(CreateCard(stationsPages, htmlPath));
        }

        private static void AddBuildStationsQuornAndWoodHouse(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            IStationsPages stationsPages = new BuildStationsQuornAndWoodHouse();
            string htmlPath = $@"GCR-QuornAndWoodHouse\{stationsPages.HtmlFileName}";
            pageBuilder.Append(CreateCard(stationsPages, htmlPath));
        }

        private static void AddStationLoughboroughStation(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            IStationsPages stationsPages = new BuildStationsLoughboroughStationPage();
            string htmlPath = $@"GCR-LoughboroughStation\{stationsPages.HtmlFileName}";
            pageBuilder.Append(CreateCard(stationsPages, htmlPath));
        }

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>Stations</h1>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
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