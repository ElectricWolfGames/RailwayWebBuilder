using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.Stations.GCR_RushcliffeHalt
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class GCR_RushcliffeHaltPage : PageDetails, IStationsPages
    {
        public GCR_RushcliffeHaltPage()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Rushcliffe Halt";
            DontShowNavigation = true;
        }

        public string HilightImage { get; } = @"GCR-RushcliffeHalt\images\P6260073.JPG";

        public string HtmlFileName
        {
            get
            {
                return MenuTitle;
            }
        }

        public StationLocationsBase StationLocations { get; } = new RushcliffeHaltGCR();

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-4'>");

            WebPage.Append(GCR_LoughboroughStation.GCR_LoughboroughStationPage.CreateStationHero(this));
            WebPage.Append(CreateGallery());

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string CreateGallery()
        {
            PageBuilder pageBuilder = new PageBuilder();
            string htmlpath = Constants._aRootPath + Constants.RushcliffeHaltFolder;
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Gallery</h2>");
            string galleryPath = Constants.RawDataPath + @"Stations\GCR-Rushcliffe Halt\\Gallery";
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, galleryPath);
            return pageBuilder.GetOutput();
        }
    }
}