using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.Stations.GCR_QuornAndWoodHouse
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    [AddGallery()]
    public class GCR_QuornAndWoodHousePage : PageDetails, IStationsPages
    {
        public GCR_QuornAndWoodHousePage()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "Quorn And WoodHouse";
            DontShowNavigation = true;
        }

        public string HilightImage { get; } = @"GCR-QuornAndWoodHouse\images\P7134452-GCR-Quorn-and-woodhouse.JPG";

        public string HtmlFileName
        {
            get
            {
                return MenuTitle;
            }
        }

        public StationLocationsBase StationLocations { get; } = new QuornWoodhouseStationGCR();

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
            string htmlpath = Constants._aRootPath + Constants.QuornAndWoodHouseFolder;
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("<h2>Gallery</h2>");
            string galleryPath = Constants.RawDataPath + @"Stations\GCR-Quorn And WoodHouse\Gallery";
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, galleryPath);
            return pageBuilder.GetOutput();
        }
    }
}