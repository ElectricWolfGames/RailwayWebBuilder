using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsQuornAndWoodHouse : BuildStationsBase, IStationssPages
    {
        private StationLocationsBase _stationLocations = new QuornWoodhouseStationGCR();
        public string HtmlFileName { get; } = "index.html";
        public string LocalPath { get; } = Constants.RootPath + Constants.QuornAndWoodHouseFolder;
        public string HtmlPath { get; } = Constants.QuornAndWoodHouseFolder;
        public string PageTitle { get; } = "Quorn And WoodHouse";

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, new StationsHeader(), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, _stationLocations);

            _pageBuilder.Append(AddQuorn_Gallery(HtmlPath, HtmlPath + "images\\"));

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        private static string AddQuorn_Gallery(string HtmlPath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Gallery</h2>");

            string path = Constants.DriveLetter + @"\Trains\eWolfModelRailwayWeb\Data\Stations\GCR-Quorn And WoodHouse\Gallery";

            string htmlpath = Constants.RootPath + "\\" + HtmlPath;
            pageBuilder.AddImages(htmlpath, htmlpath + "images", path);

            return pageBuilder.GetString();
        }

    }
}
