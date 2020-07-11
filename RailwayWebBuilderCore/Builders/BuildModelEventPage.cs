using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Helpers;
using RailwayWebBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RailwayWebBuilder.Builders
{
    public class BuildModelEventPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            pageDetails.CopyLayoutsToKeywords();

            Console.WriteLine(pageDetails.Name);

            List<string> images = ImageHelper.GetAllImages(pageDetails.ImagesPath);

            AddImageToLayouts(pageDetails, images);

            // create folders
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.ModelEvents);
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.ModelEvents + "\\" + pageDetails.ImageFolder);
            Directory.CreateDirectory(Constants.RootPath + "\\" + Constants.ModelEvents + "\\" + pageDetails.ImageFolder + @"\images");

            string htmlpath = Constants.RootPath + "\\" + Constants.ModelEvents + "\\" + pageDetails.ImageFolder + "\\";
            string imagePath = Constants.RootPath + "\\" + Constants.ModelEvents + "\\" + pageDetails.ImageFolder + @"\images";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(PageHeaderHelper.PageHeader(pageDetails));
            stringBuilder.Append("<body>");
            stringBuilder.Append(NavBarHelper.NavBar("../../"));
            stringBuilder.AppendLine("<div class='container mt-4'>");
            stringBuilder.Append(Jumbotron(pageDetails));

            stringBuilder.AppendLine("<div class='row'>");

            AddImagesByLayout(images, pageDetails, htmlpath, imagePath, stringBuilder);

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine(HTMLHelper.Modal());

            stringBuilder.Append("<script src='../../Scripts/script.js'></script>");
            stringBuilder.Append("</body>");

            File.WriteAllText(htmlpath + "index.html", stringBuilder.ToString());
        }

        private static void AddImagesByLayout(List<string> images, IModelEvent pageDetails, string htmlpath, string imagePath, StringBuilder stringBuilder)
        {
            bool any = false;
            int count = 2;
            foreach (Data.LayoutDetails layout in pageDetails.Layouts)
            {
                if (!layout.ImagePaths.Any())
                {
                    continue;
                }

                stringBuilder.AppendLine("</div>");
                stringBuilder.Append($"<hr/><h2><a id='{layout.IDName}'> {layout.Name}</a></h2>");
                stringBuilder.AppendLine("<div class='row'>");

                count = 2;
                foreach (string layoutImage in layout.ImagePaths)
                {
                    if (images.Contains(layoutImage))
                    {
                        HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, layoutImage);
                        if (count-- == 0)
                        {
                            count = 2;
                            stringBuilder.AppendLine("</div></div>");
                            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
                        }
                        any = true;
                        images.Remove(layoutImage);
                    }
                }
            }
            if (images.Any())
            {
                count = 2;
                if (any)
                {
                    stringBuilder.AppendLine("</div>");
                    stringBuilder.Append("<hr/><h4>Others</h4>");
                    stringBuilder.AppendLine("<div class='row'>");
                }
                foreach (string image in images)
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, stringBuilder, image);
                    if (count-- == 0)
                    {
                        count = 2;
                        stringBuilder.AppendLine("</div>");
                        stringBuilder.AppendLine("</div>");
                        stringBuilder.AppendLine("<div class='container mt-4'>");
                        stringBuilder.AppendLine("<div class='row'>");
                    }
                }
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

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>{pageDetails.Name}</h1>");
            stringBuilder.AppendLine($"<p'>{pageDetails.Descrption}</p>");

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
    }
}
