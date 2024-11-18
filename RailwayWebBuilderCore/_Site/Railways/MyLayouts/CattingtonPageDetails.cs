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

namespace RailwayWebBuilderCore._Site.Railways.MyLayouts
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    [AddGallery()]
    public class CattingtonPageDetails : PageDetails
    {
        public List<ILayoutPagesDetails> LayoutDetails;
        private const int DetailsPerPage = 10;

        public CattingtonPageDetails()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "Cattington";
            MenuTitle = "Cattington";
            DontShowNavigation = true;
            DontBuildPage = true;
        }

        public int EndIndex { get; internal set; }
        public int PageIndex { get; internal set; }
        public int StartIndex { get; internal set; }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.Append("</br>");
            WebPage.Append(CreateHero());
            WebPage.HtmlPath = Constants.MyLayouts;
            if (PageIndex == 0)
            {
                WebPage.HtmlTitle = $"index.html";
            }
            else
            {
                WebPage.HtmlTitle = $"index{PageIndex.ToString("D2")}.html";
            }
            WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
            WebPage.SetDontBuild = false;

            int totalPages = (LayoutDetails.Count(x => x.Active) / DetailsPerPage);
            WebPage.Append(NavBarHelper.Pagination(PageIndex, totalPages + 1));

            for (int index = StartIndex; index < EndIndex; index++)
            {
                if (index > LayoutDetails.Count - 1)
                    break;

                WebPage.Append(BuildDetails(LayoutDetails[index]));
            }

            WebPage.Append(NavBarHelper.Pagination(PageIndex, totalPages + 1));
            WebPage.Append("</div>");
            WebPage.Append(HTMLRailHelper.Modal());
            WebPage.Append("<script src='../Scripts/script.js'></script>");

            WebPage.EndBody();
            WebPage.Output();
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

        private static string BuildDetails(ILayoutPagesDetails detail)
        {
            HTMLBuilder pageBuilder = new();

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
                pageBuilder.AddImagesGroupedByDate(Constants.FullMyLayouts, detail.ExportImagePath, detail.RawImagePath);
            }

            return pageBuilder.Output();
        }

        private static string CreateHero()
        {
            string imageName = Constants._aaDriveLetter + "Trains/_WebsiteData/Others/images/";
            string imageHtmlName = "../Others/images/";

            HTMLBuilder pageBuilder = new();
            pageBuilder.JumbotronWithImage("<h1>Cattington</h1>",
                "<p'>This is our first layout, Hope you enjoy it.</p>",
                imageName,
                imageHtmlName,
                "CATTINGTON.png");

            return pageBuilder.Output();
        }
    }
}