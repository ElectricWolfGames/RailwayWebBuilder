using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders
{
    public class BuildCatalogPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            string htmlpath = Constants.FullCatalog;
            Directory.CreateDirectory(htmlpath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, new CatalogHeader());
            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Append(Jumbotron(null));

            pageBuilder.Append(AddDetails(htmlpath, htmlpath + "images\\", "Wagons"));
            pageBuilder.Append(AddDetails(htmlpath, htmlpath + "images\\", "Loco"));
            pageBuilder.Append(AddDetails(htmlpath, htmlpath + "images\\", "Coach"));

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLHelper.Modal());

            pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            pageBuilder.Output();
        }

        private static string AddDetails(string htmlpath, string imagePath, string name)
        {
            Directory.CreateDirectory(imagePath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");

            pageBuilder.Append($"<h2>{name}</h2>");

            string path = $@"F:\Trains\eWolfModelRailwayWeb\Data\Catalog\{name}";
            List<string> images = ImageHelper.GetAllImages(path);

            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");
            return pageBuilder.GetString();
        }

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder pageBuilder = new StringBuilder();

            pageBuilder.Append("<div class='jumbotron'>");
            pageBuilder.Append("<div class='row'>");
            pageBuilder.Append("<div class='col-md-4'>");
            pageBuilder.Append($"<h1>Catalog</h1>");

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            return pageBuilder.ToString();
        }
    }
}
