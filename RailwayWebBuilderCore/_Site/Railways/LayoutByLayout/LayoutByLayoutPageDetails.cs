using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore._SiteData.ModelRailways;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;
using System.Windows.Controls;

namespace RailwayWebBuilderCore._Site.Railways.LayoutByLayout
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    [AddGallery()]
    public class LayoutByLayoutPageDetails : PageDetails
    {
        public LayoutDetails LayoutDetails;
        public LayoutNamesEnums Post;
        public LayoutNamesEnums Pre;
        internal ILayoutBase LayoutByLayoutDetails;

        public LayoutByLayoutPageDetails()
        {
            WebPage = new WebPage(this);
            DisplayTitle = "To update later";
            MenuTitle = "To update later";
            DontShowNavigation = true;
            DontBuildPage = true;
        }

        public override void CreatePage()
        {
            WebPage.AddHeader(this);
            WebPage.AddNavigation(NavigationTypes.Main, @"../../");
            WebPage.StartBody();

            WebPage.Append("<div class='container mt-12'>");

            WebPage.HtmlPath = Constants.LayoutByLayout + "/";
            WebPage.HtmlTitle = $"{MenuTitle}.html";

            WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
            WebPage.SetDontBuild = false;

            // TODO: keywords

            /*ModelEvent.CopyLayoutsToKeywords();
            List<string> images = ImageHelper.GetAllImages(ModelEvent.ImagesPath);
            AddImageToLayouts(ModelEvent, images);

            */
            WebPage.Append("<div class='container mt-4'>");

            WebPage.Append(NavButtons());

            WebPage.Append(Jumbotron());

            WebPage.Append(AddImages());
            if (LayoutByLayoutDetails.Images.Count > 6)
            {
                WebPage.Append(NavButtons());
            }

            WebPage.Append("</div>");
            WebPage.Append(HTMLRailHelper.Modal());
            WebPage.Append("<script src='../Scripts/script.js'></script>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private string AddImages()
        {
            HTMLBuilder htmBuilder = new();

            HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, null);
            foreach (var lp in LayoutByLayoutDetails.Images)
            {
                string folder = $"../{Constants.ModelEvents}/{lp.Folder}/";

                HTMLHelper.AddImageToGallery(folder, lp, htmBuilder);
            }
            HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);
            return htmBuilder.Output();
        }

        private string Jumbotron()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine($"<h1>{DisplayTitle} </h1>");
            stringBuilder.AppendLine($"<h3>{LayoutDetails.GaugeName}</h3>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine($"<p'>{LayoutByLayoutDetails.Description}</p>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

        private string NavButtons()
        {
            StringBuilder sb = new();

            var preDetails = new LayoutDetails(Pre);
            string preButton = $"<a href='{preDetails.NameEnum}.html' class='btn btn-info btn-lg'><h1>{preDetails.Name}</h1></a>";

            var PostDetails = new LayoutDetails(Post);
            string postButton = $"<a href='{PostDetails.NameEnum}.html' class='float-right btn btn-info btn-lg'><h1>{PostDetails.Name}</h1></a>";

            sb.AppendLine("<Table width ='100%'>");
            sb.AppendLine("  <tr>");
            sb.AppendLine("    <td width ='40%'>");
            if (Pre != LayoutNamesEnums.None)
                sb.AppendLine($"{preButton}");
            sb.AppendLine("    </td>");
            sb.AppendLine("    <td width ='20%'>");
            sb.AppendLine("    </td>");
            sb.AppendLine("    <td width ='40%'>");
            if (Post != LayoutNamesEnums.None)
                sb.AppendLine($"{postButton}");
            sb.AppendLine("    </td>");
            sb.AppendLine("  </tr>");
            sb.AppendLine("</Table>");
            sb.AppendLine("<br/>");
            sb.AppendLine("<br/>");
            return sb.ToString();
        }
    }
}