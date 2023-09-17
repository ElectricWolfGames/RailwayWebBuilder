using eWolfBootstrap.Builders;
using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Builders.Stations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore.Data.StationsPages
{
    public class Mainline_LoughboroughStationOld : BuildStationsBase, IStationsPages,IPageDetails
    {
        public string HilightImage { get; } = @"Mainline-LoughboroughStation\images\P9070773-2022-09-07-Loughborough-station.JPG";
        public string HtmlFileName { get; } = "index.html";
        public string HtmlPath { get; } = Constants.MainlineLoughboroughStationFolder;
        public string LocalPath { get; } = Constants._aRootPath + Constants.MainlineLoughboroughStationFolder;
        public string PageTitle { get; } = "Mainline Loughborough Station";
        public StationLocationsBase StationLocations { get; } = new Mainline_LoughboroughAddress();

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, CreateHeader(StationLocations), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, StationLocations);

            string path = Constants.RawDataPath + @"Stations\Mainline-LoughboroughStation\Gallery\";
            Add_Gallery(HtmlPath, HtmlPath + "images\\", path);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }
    }
}