using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._Site.Railways.Locomotives;
using System.IO;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    public class LocoRefPageDetails : PageDetails
    {
        public LocoRefPageDetails()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "bah2";
            MenuTitle = "bah3";
            DontShowNavigation = true;
            DontBuildPage = true;
        }

        public LocomotiveDetailsBase LocomotiveDetailsBase { get; set; }

        public string CreateGallary()
        {
            string imagePath = $"{LocomotiveDetailsBase.LocalPath}\\images";
            Directory.CreateDirectory(imagePath);
            PageBuilder pageBuilder = new PageBuilder();

            pageBuilder.AddImagesGroupedByDate(LocomotiveDetailsBase.LocalPath, LocomotiveDetailsBase.LocalPath + "images", LocomotiveDetailsBase.RawImagePath);

            return pageBuilder.GetOutput();
        }

        public string CreateHero()
        {
            HTMLBuilder pageBuilder = new HTMLBuilder();
            pageBuilder.Jumbotron(LocomotiveDetailsBase.Title, LocomotiveDetailsBase.Class);
            return pageBuilder.Output();
        }

        public override void CreatePage()
        {
            DisplayTitle = LocomotiveDetailsBase.PageTitle;
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append(CreateHero());

            MenuTitle = LocomotiveDetailsBase.StockType.ToString();
            WebPage.Append(LocoRef.CreateGroups(this, "../"));

            WebPage.HtmlPath = LocomotiveDetailsBase.HtmlPath;
            WebPage.HtmlTitle = $"{LocomotiveDetailsBase.PageTitle}.html";
            WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
            WebPage.SetDontBuild = false;

            WebPage.Append(CreateLocoDetails());
            WebPage.Append(CreateGallary());

            WebPage.Append("</div>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string CreateLocoDetails()
        {
            HTMLBuilder pageBuilder = new HTMLBuilder();

            pageBuilder.NewLine();

            if (!string.IsNullOrWhiteSpace(LocomotiveDetailsBase.Paragraph1))
                pageBuilder.Text($"<p>{LocomotiveDetailsBase.Paragraph1}</p>");

            if (!string.IsNullOrWhiteSpace(LocomotiveDetailsBase.Paragraph2))
                pageBuilder.Text($"<p>{LocomotiveDetailsBase.Paragraph2}</p>");

            if (!string.IsNullOrWhiteSpace(LocomotiveDetailsBase.Paragraph3))
                pageBuilder.Text($"<p>{LocomotiveDetailsBase.Paragraph3}</p>");

            pageBuilder.NewLine();

            return pageBuilder.Output();
        }
    }
}