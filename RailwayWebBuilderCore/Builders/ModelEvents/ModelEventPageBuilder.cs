﻿using eWolfBootstrap.Builders;
using eWolfBootstrap.Helpers;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RailwayWebBuilderCore.Builders.ModelEvents
{
    public class ModelEventPageBuilder
    {
        public static void Build(IModelEvent pageDetails)
        {
            pageDetails.ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.GALLERY);

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

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, pageDetails, "../../");

            pageBuilder.Append(NavBarHelper.NavBar("../../"));
            pageBuilder.Append("<div class='container mt-4'>");

            pageBuilder.Append(Jumbotron(pageDetails));

            LocationsService ls = ServiceLocator.Instance.GetService<LocationsService>();
            ls.AddLocation(pageDetails);

            AddImagesByLayout(images, pageDetails, htmlpath, imagePath, pageBuilder);

            pageBuilder.Output();
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
    }
}