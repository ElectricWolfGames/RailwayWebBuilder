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
    public class GCR_LoughboroughStationPageOLD : BuildStationsBase, IStationsPages,IPageDetails
    {
        public string HilightImage { get; } = @"GCR-LoughboroughStation\images\PA210666-GCR-Loughborough.JPG";
        public string HtmlFileName { get; } = "index.html";
        public string HtmlPath { get; } = Constants.LoughboroughStationFolder;
        public string LocalPath { get; } = Constants._aRootPath + Constants.LoughboroughStationFolder;
        public string PageTitle { get; } = "Loughborough Station";
        public StationLocationsBase StationLocations { get; } = new LoughboroughGCR();

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, CreateHeader(StationLocations), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, StationLocations);

            string path = Constants.RawDataPath + @"Stations\GCR-Loughborough Station\Gallery";
            Add_Gallery(HtmlPath, HtmlPath + "images\\", path);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }
    }
}