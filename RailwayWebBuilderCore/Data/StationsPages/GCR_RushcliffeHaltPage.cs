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
    /*public class GCR_RushcliffeHaltPageOld : BuildStationsBase, IStationsPages, IPageDetails
    {
        public string HilightImage { get; } = @"GCR-RushcliffeHalt\images\P6260073.JPG";
        public string HtmlFileName { get; } = "index.html";
        public string HtmlPath { get; } = Constants.RushcliffeHaltFolder;
        public string LocalPath { get; } = Constants._aRootPath + Constants.RushcliffeHaltFolder;
        public string PageTitle { get; } = "Rushcliffe Halt";
        public StationLocationsBase StationLocations { get; } = new RushcliffeHaltGCR();

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, CreateHeader(StationLocations), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, StationLocations);

            _pageBuilder.Append(AddHalt_001(HtmlPath, HtmlPath + "images\\"));

            string path = Constants.RawDataPath + @"Stations\GCR-Rushcliffe Halt\Gallery";
            Add_Gallery(HtmlPath, HtmlPath + "images\\", path);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        private static string AddHalt_001(string HtmlPath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>First trip to Rushcliffe Halt featuring a class 66</h2> 26/06/2020");

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/NemRaAwWhms";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            return pageBuilder.GetString();
        }
    }*/
}