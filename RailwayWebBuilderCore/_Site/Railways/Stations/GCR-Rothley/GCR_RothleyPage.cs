using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.Stations.GCR_Rothley
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    public class GCR_RothleyPage : PageDetails, IStationsPages
    {
        public GCR_RothleyPage()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Rothley";
            DontShowNavigation = true;
        }

        public string HilightImage { get; } = @"GCR-Rothley\images\P7134422-GCR-Rothley.JPG";

        public string HtmlFileName
        {
            get
            {
                return MenuTitle;
            }
        }

        public StationLocationsBase StationLocations { get; } = new RothleyStationGCR();

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
            string htmlpath = Constants._aRootPath + Constants.RothleyFolder;
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Gallery</h2>");
            string galleryPath = Constants.RawDataPath + @"Stations\GCR-Rothley\Gallery";
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, galleryPath);
            return pageBuilder.GetOutput();
        }
    }
}