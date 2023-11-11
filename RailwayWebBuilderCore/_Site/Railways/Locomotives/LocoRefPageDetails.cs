using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Helpers;
using System.IO;

namespace RailwayWebBuilderCore._Site.Railways.Locomotives
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    [AddGallery()]
    public class LocoRefPageDetails : PageDetails
    {
        public LocoRefPageDetails()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Loco ref";
            MenuTitle = "Loco Ref";
            DontShowNavigation = true;
            DontBuildPage = true;
        }

        public IDieselClass DieselClassBase { get; set; }
        public string GalleryPath { get; set; }
        public string LocoNumber { get; set; }

        public override void CreatePage()
        {
            DisplayTitle = $"{DieselClassBase.ClassName}: {LocoNumber}";
            MenuTitle = $"{DieselClassBase.ClassName}: {LocoNumber}";

            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append(LocoRef.CreateHero(this));
            WebPage.Append(LocoRef.CreateGroups(this, "../"));

            WebPage.Append($"<h2>{DieselClassBase.ClassName}: {LocoNumber}</h2>");
            WebPage.Append($"<p>{DieselClassBase.Paragraph1}</p>");
            WebPage.Append($"<p>{DieselClassBase.Paragraph2}</p>");

            WebPage.Append(CreateGallery());

            WebPage.HtmlPath = "Locomotives\\Ref";
            WebPage.HtmlTitle = $"{LocoNumber}.html";

            WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
            WebPage.SetDontBuild = false;

            WebPage.Append("</div>");
            WebPage.Append(HTMLRailHelper.Modal());
            WebPage.Append("<script src='../../Scripts/script.js'></script>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateGallery()
        {
            var pageBuilder = new HTMLBuilder();
            string htmlpath = Constants._aRootPath + @"\\Locomotives\\Ref\\";
            string imagePath = $"{htmlpath}images";

            Directory.CreateDirectory(imagePath);
            pageBuilder.Text($"<hr/>");
            pageBuilder.Text("<h2>Gallery</h2>");
            pageBuilder.AddImagesGroupedByDate(htmlpath, imagePath, GalleryPath);
            return pageBuilder.Output();
        }
    }
}