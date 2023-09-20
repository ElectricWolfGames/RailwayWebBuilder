using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Stations.StationLocations;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.Stations.GCR_A60Bridge
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    [AddGallery()]
    public class GCR_A60BridgePage : PageDetails, IStationsPages
    {
        public GCR_A60BridgePage()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "";
            MenuTitle = "A60 Bridge";
            DontShowNavigation = true;
        }

        public string HilightImage { get; } = @"GCR-A60Bridge\images\P8070154-2022-08-07-A60Bridge326.JPG";

        public string HtmlFileName
        {
            get
            {
                return MenuTitle;
            }
        }

        public StationLocationsBase StationLocations { get; } = new LoughboroughA60Bridge();

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
            string htmlpath = Constants._aRootPath + Constants.A60StationFolder;
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("<h2>Gallery</h2>");
            string galleryPath = Constants.RawDataPath + @"Stations\GCR A60 Bridge\Gallery";
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, galleryPath);
            return pageBuilder.GetOutput();
        }
    }
}