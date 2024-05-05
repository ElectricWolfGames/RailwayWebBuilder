using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData.StationLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.Stations.GCR_LoughboroughStation
{
    [PageTitle("index.html")]
    [Navigation(NavigationTypes.Main, 1)]
    [AddGallery()]
    public class GCR_LoughboroughStationPage : PageDetails, IStationsPages
    {
        public GCR_LoughboroughStationPage()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Loughborough Central Station, LE11 1RW";
            MenuTitle = "Loughborough Station";
            DontShowNavigation = true;
        }

        public string HilightImage { get; } = @"GCR-LoughboroughStation\images\PA210666-GCR-Loughborough.JPG";

        public string HtmlFileName
        {
            get
            {
                return MenuTitle;
            }
        }

        public StationLocationsBase StationLocations { get; } = new LoughboroughGCR();

        public static string CreateStationHero(PageDetails pageDetails)
        {
            HTMLBuilder pageBuilder = new HTMLBuilder();

            pageBuilder.Text("<div class='jumbotron'>");
            pageBuilder.Text("<div class='row'>");
            pageBuilder.Text("<div class='col-md-4'>");
            pageBuilder.Text($"<h1>{pageDetails.MenuTitle}</h1>");
            pageBuilder.Text($"<h5>{pageDetails.DisplayTitle}</h5>");
            pageBuilder.Text("</div>");
            pageBuilder.Text("</div>");
            pageBuilder.Text("</div>");

            return pageBuilder.Output();
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-4'>");

            WebPage.Append(CreateStationHero(this));
            WebPage.Append(CreateGallery());

            WebPage.Append("</div>");
            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string CreateGallery()
        {
            var pageBuilder = new HTMLBuilder();
            string htmlpath = Constants._aRootPath + Constants.LoughboroughStationFolder;
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("<h2>Gallery</h2>");
            string galleryPath = Constants.RawDataPath + @"Stations\GCR-Loughborough Station\Gallery";
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, galleryPath);
            return pageBuilder.Output();
        }
    }
}