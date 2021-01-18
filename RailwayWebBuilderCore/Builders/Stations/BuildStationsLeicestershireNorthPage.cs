using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsLeicestershireNorthPage : BuildStationsBase, IStationsPages
    {
        public string HilightImage { get; } = @"GCR-LeicestershireNorth\images\P7134400-GCR-Leicester-north.JPG";
        public string HtmlFileName { get; } = "index.html";
        public string HtmlPath { get; } = Constants.LeicestershireNorthFolder;
        public string LocalPath { get; } = Constants.RootPath + Constants.LeicestershireNorthFolder;
        public string PageTitle { get; } = "Leicestershire North";
        public StationLocationsBase StationLocations { get; } = new LeicesterNorthStationGCR();

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, CreateHeader(StationLocations), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, StationLocations);

            string path = Constants.RawDataPath + @"Stations\GCR-Leicestershire North\Gallery";
            Add_Gallrey(HtmlPath, HtmlPath + "images\\", path);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }
    }
}