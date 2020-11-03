﻿using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsRushcliffeHaltPage : BuildStationsBase, IStationssPages
    {
        private StationLocationsBase _stationLocations = new RushcliffeHaltGCR();
        public string HtmlFileName { get; } = "index.html";
        public string LocalPath { get; } = Constants.RootPath + Constants.RushcliffeHaltFolder;
        public string HtmlPath { get; } = Constants.RushcliffeHaltFolder;
        public string PageTitle { get; } = "Rushcliffe Halt";

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, new StationsHeader(), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, _stationLocations);

            _pageBuilder.Append(AddHalt_001(HtmlPath, HtmlPath + "images\\"));

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }

        private static string AddHalt_001(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>First trip to Rushcliffe Halt featuring a class 66</h2> 26/06/2020");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\Stations\Rushcliffe Halt\2020-06-26\";

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/NemRaAwWhms";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.AddImages(htmlpath, imagePath, path);

            return pageBuilder.GetString();
        }
    }
}
