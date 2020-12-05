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
    public class BuildStationsLoughboroughStationPage : BuildStationsBase, IStationssPages
    {
        private StationLocationsBase _stationLocations = new LoughboroughGCR();
        public string HtmlFileName { get; } = "index.html";
        public string HtmlPath { get; } = Constants.LoughboroughStationFolder;
        public string LocalPath { get; } = Constants.RootPath + Constants.LoughboroughStationFolder;
        public string PageTitle { get; } = "Loughborough Station";

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, new StationsHeader(), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, _stationLocations);

            AddLoughborough_002(HtmlPath + "images\\");
            AddLoughborough_001(HtmlPath + "images\\");

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        private void AddLoughborough_001(string imagePath)
        {
            string htmlpath = Constants.RootPath + "\\" + HtmlPath;
            Directory.CreateDirectory(imagePath);

            _pageBuilder.Append($"<hr/>");
            _pageBuilder.Append("<h2>Loughborough Station viewed from a far</h2> 17 and 18/10/2020");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\Stations\Loughborough Station\2020-10-17\";
            _pageBuilder.AddImages(htmlpath, htmlpath + "images", path);
        }

        private void AddLoughborough_002(string imagePath)
        {
            string htmlpath = Constants.RootPath + "\\" + HtmlPath;

            Directory.CreateDirectory(imagePath);

            _pageBuilder.Append($"<hr/>");
            _pageBuilder.Append("<h2>Class 101 Stopping and starting, Approuching loughborough Station</h2> 31/10/2020");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\Stations\Loughborough Station\2020-11-01\";
            _pageBuilder.AddImages(htmlpath, htmlpath + "images", path);
        }
    }
}
