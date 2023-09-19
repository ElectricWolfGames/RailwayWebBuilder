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
using System.IO;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore._Site.Railways.ModelEvents
{
    [PageTitle("Place holder Page")]
    [Navigation(NavigationTypes.Main, 2)]
    [AddGallery()]
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

            WebPage.HtmlPath = Constants.ModelEvents + "\\" + ModelEvent.ImageFolder;
            WebPage.HtmlTitle = $"index.html";

            WebPage.SetRootAddress = RootAddress = @"E:\eWolfSiteUploads\Railways"; // TODO Make this a const!
            WebPage.SetDontBuild = false;

            // ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.GALLERY); ?

            ModelEvent.CopyLayoutsToKeywords();
            List<string> images = ImageHelper.GetAllImages(ModelEvent.ImagesPath);
            AddImageToLayouts(ModelEvent, images);

            // create folders
            Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.ModelEvents);
            Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder);
            Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder + @"\images");

            string htmlpath = Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder + "\\";
            string imagePath = Constants._aRootPath + "\\" + Constants.ModelEvents + "\\" + ModelEvent.ImageFolder + @"\images";

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, ModelEvent, "../../../");

            pageBuilder.Append("<div class='container mt-4'>");

            pageBuilder.Append(Jumbotron(ModelEvent));

            LocationsService ls = ServiceLocator.Instance.GetService<LocationsService>();
            ls.AddLocation(ModelEvent);

            AddImagesByLayout(images, ModelEvent, htmlpath, imagePath, pageBuilder);

            WebPage.Append(pageBuilder.GetString());
            // Show event details

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

        private static void AddImagesByLayout(List<string> images, IModelEvent pageDetails, string htmlpath, string imagePath, eWolfBootstrap.Interfaces.IPageBuilder stringBuilder)
        {
            foreach (Data.LayoutDetails layout in pageDetails.Layouts)
            {
                if (!layout.ImagePaths.Any())
                {
                    continue;
                }

                HTMLHelper.Gallery.AddGalleryHeader(stringBuilder, layout.IDName);

                stringBuilder.Append(AddDescription(layout));

                foreach (string layoutImage in layout.ImagePaths)
                {
                    if (images.Contains(layoutImage))
                    {
                        HTMLHelper.AddImageToGallery(htmlpath, imagePath, stringBuilder, layoutImage);
                        images.Remove(layoutImage);
                    }
                }
                HTMLHelper.Gallery.AddGalleryFooter(stringBuilder);
            }

            if (images.Any())
            {
                HTMLHelper.Gallery.AddGalleryHeader(stringBuilder, null);

                foreach (string image in images)
                {
                    HTMLHelper.AddImageToGallery(htmlpath, imagePath, stringBuilder, image);
                }

                HTMLHelper.Gallery.AddGalleryFooter(stringBuilder);
            }
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

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>{pageDetails.Name}</h1>");
            stringBuilder.AppendLine($"<p'>{pageDetails.EventDates}</p>");
            stringBuilder.AppendLine($"<p'>{pageDetails.Descrption}</p>");
            stringBuilder.AppendLine($"<p'>{pageDetails.Location?.Address}</p>");

            if (pageDetails.Layouts.Any())
            {
                // add the extra details.
                StringBuilder sb = new StringBuilder();
                sb.Append("<p class='font-weight-bold'>");
                sb.Append("Featuring layouts.");
                sb.Append("</p>");
                sb.Append("<p>");

                List<string> names = new List<string>();
                foreach (Data.LayoutDetails layout in pageDetails.Layouts)
                {
                    if (layout.ImagePaths.Any())
                    {
                        names.Add($"<a href='#{layout.IDName}'>{layout.Name}</a>");
                    }
                }
                sb.Append(string.Join(", ", names));
                sb.Append("</p>");
                stringBuilder.AppendLine(sb.ToString());
            }

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("<div class='col-md-6'>");
            if (!string.IsNullOrWhiteSpace(pageDetails.YouTubeLink))
            {
                stringBuilder.AppendLine("<div class='embed-responsive embed-responsive-16by9'>");
                stringBuilder.AppendLine($"<iframe src='{pageDetails.YouTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
                stringBuilder.AppendLine("</div>");
            }

            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
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