using eWolfBootstrap.Builders;

using eWolfBootstrap.Helpers;
using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Attributes;
using eWolfBootstrap.SiteBuilder.Enums;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.LayoutByLayout
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    [AddGallery()]
    public class LayoutByLayoutPageDetails : PageDetails
    {
        public ILayoutByLayout layoutDetails;

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

            WebPage.Append(Jumbotron(layoutDetails));

            HTMLBuilder htmBuilder = new HTMLBuilder();

            HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, null);
            foreach (var lp in layoutDetails.Images)
            {
                string folder = $"../{Constants.ModelEvents}/{lp.Folder}/";

                HTMLHelper.AddImageToGallery(folder, lp, htmBuilder);
            }
            HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);

            WebPage.Append(htmBuilder.Output());

            WebPage.Append("</div>");
            WebPage.Append(HTMLRailHelper.Modal());
            WebPage.Append("<script src='../Scripts/script.js'></script>");

            WebPage.EndBody();
            WebPage.Output();
        }

        private static string AddDescription(Data.LayoutDetails layoutDetails)
        {
            ModelLayoutServices mls = ServiceLocator.Instance.GetService<ModelLayoutServices>();
            var layout = mls.Layouts.FirstOrDefault(x => x.Name == layoutDetails.NameEnum);

            if (layout == null)
                return String.Empty;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");

            stringBuilder.AppendLine(layout.Description);
            stringBuilder.AppendLine("</br></br>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            return stringBuilder.ToString();
        }

        private static void AddImageToLayouts(IModelEvent pageDetails, List<string> images)
        {
            foreach (string imageName in images)
            {
                foreach (Data.LayoutDetails layout in pageDetails.Layouts)
                {
                    if (layout.Path != null && imageName.Contains(layout.Path))
                    {
                        layout.ImagePaths.Add(imageName);
                    }
                }
            }
        }

        private string AddImagesByLayout(List<string> images, IModelEvent pageDetails, string htmlpath, string imagePath)
        {
            LayoutbyLayoutDetailsServices lbls = ServiceLocator.Instance.GetService<LayoutbyLayoutDetailsServices>();

            HTMLBuilder htmBuilder = new HTMLBuilder();

            foreach (Data.LayoutDetails layout in pageDetails.Layouts)
            {
                if (!layout.ImagePaths.Any())
                {
                    continue;
                }

                HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, layout.IDName);

                htmBuilder.TextNewLine(AddDescription(layout));

                htmBuilder.Text("</div>");
                htmBuilder.Text("<div class='row'>");

                var lbl = lbls.FindLayout(layout.NameEnum);

                foreach (string layoutImage in layout.ImagePaths)
                {
                    if (images.Contains(layoutImage))
                    {
                        ImagesPair ip = HTMLHelper.AddImageToGallery(htmlpath, imagePath, htmBuilder, layoutImage);
                        if (lbl != null)
                        {
                            lbl.Images.Add(ip);
                        }

                        images.Remove(layoutImage);
                    }
                }
                HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);
            }

            if (images.Any())
            {
                HTMLHelper.Gallery.AddGalleryHeader(htmBuilder, null);

                foreach (string image in images)
                {
                    HTMLHelper.AddImageToGallery(htmlpath, imagePath, htmBuilder, image);
                }

                HTMLHelper.Gallery.AddGalleryFooter(htmBuilder);
            }

            return htmBuilder.Output();
        }

        private string Jumbotron(ILayoutByLayout pageDetails)
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-12'>");
            stringBuilder.AppendLine($"<h1>{DisplayTitle}</h1>");
            stringBuilder.AppendLine($"<p'>{pageDetails.Description}</p>");

            return stringBuilder.ToString();
        }
    }
}