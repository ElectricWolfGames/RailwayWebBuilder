﻿using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsQuornAndWoodHouse : BuildStationsBase, IStationsPages
    {
        public string HilightImage { get; } = @"GCR-QuornAndWoodHouse\images\P7134452-GCR-Quorn-and-woodhouse.JPG";
        public string HtmlFileName { get; } = "index.html";
        public string HtmlPath { get; } = Constants.QuornAndWoodHouseFolder;
        public string LocalPath { get; } = Constants.RootPath + Constants.QuornAndWoodHouseFolder;
        public string PageTitle { get; } = "Quorn And WoodHouse";
        public StationLocationsBase StationLocations { get; } = new QuornWoodhouseStationGCR();

        public void Build()
        {
            Directory.CreateDirectory(HtmlPath);

            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, CreateHeader(StationLocations), "../../");

            _pageBuilder.Append(NavBarHelper.NavBar("../../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");
            Jumbotron(PageTitle, StationLocations);

            string path = Constants.RawDataPath + @"Stations\GCR-Quorn And WoodHouse\Gallery";
            Add_Gallrey(HtmlPath, HtmlPath + "images\\", path);

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Append(HTMLRailHelper.Modal());

            _pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            _pageBuilder.Output();
        }
    }
}