using eWolfBootstrap.Builders;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RailwayWebBuilderCore._Site.Railways.ModelEvents
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    public class ModelRailwayPageDetails : PageDetails
    {
        public IModelEvent ModelEvent;

        public ModelRailwayPageDetails()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "bah";
            MenuTitle = "hab";
            DontShowNavigation = true;
            DontBuildPage = true;
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append(CreateHero());
            WebPage.HtmlPath = Constants.MyLayouts;
            WebPage.HtmlTitle = $"index.html";

            WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
            WebPage.SetDontBuild = false;

          
            
            // Show event details 

            WebPage.Append("</div>");
            WebPage.Append(HTMLRailHelper.Modal());
            WebPage.Append("<script src='../Scripts/script.js'></script>");

            //WebPage.EndBody();
            //WebPage.Output();
        }

        private static string AddYoutubePreview(string youTubeLink)
        {
            var pageBuilder = new HTMLBuilder();

            pageBuilder.Text("<div class='col-md-8'>");
            pageBuilder.Text("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Text($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Text("</div>");
            pageBuilder.Text("</div>");

            return pageBuilder.Output();
        }

        private string BuildDetails(ILayoutPagesDetails detail)
        {
            HTMLBuilder pageBuilder = new HTMLBuilder();

            if (!detail.Active)
                return "";

            pageBuilder.Text($"<hr/>");
            pageBuilder.Text(detail.Title);
            pageBuilder.Text(detail.When.ToShortDateString());
            pageBuilder.Text(detail.Details.ToString());

            if (!string.IsNullOrWhiteSpace(detail.YouTubeLink))
            {
                string youTubeLink = $"https://www.youtube.com/embed/{detail.YouTubeLink}";
                pageBuilder.Text(AddYoutubePreview(youTubeLink));
            }

            if (!string.IsNullOrWhiteSpace(detail.ExportImagePath))
            {
                Directory.CreateDirectory(detail.ExportImagePath);
                var pb = new PageBuilder();
                pb.AddImages(Constants.FullMyLayouts, detail.ExportImagePath, detail.RawImagePath);
                pageBuilder.Text(pb.GetOutput());
            }

            return pageBuilder.Output();
        }

        private string CreateHero()
        {
            string imageName = Constants._aaDriveLetter + "Trains/_WebsiteData/Others/images/";
            string imageHtmlName = "../Others/images/";

            HTMLBuilder pageBuilder = new HTMLBuilder();
            pageBuilder.JumbotronWithImage("<h1>Cattington</h1>",
                "<p'>Now it's our turn, We have just started to build our first layout." +
                "</br>We are Building Cattington, and we are updatd details here every week or so.</p>",
                imageName,
                imageHtmlName,
                "CATTINGTON.png");

            return pageBuilder.Output();
        }
    }
}