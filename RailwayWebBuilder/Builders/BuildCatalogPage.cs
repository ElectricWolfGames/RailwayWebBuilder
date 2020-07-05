using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Data;
using RailwayWebBuilder.Helpers;
using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilder.Builders
{
    public class BuildCatalogPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            string htmlpath = Constants.FullCatalog;
            Directory.CreateDirectory(htmlpath);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(PageHeaderHelper.PageHeader(new CatalogHeader()));
            stringBuilder.Append("<body>");
            stringBuilder.Append(NavBarHelper.NavBar("../"));
            stringBuilder.AppendLine("<div class='container mt-4'>");
            stringBuilder.Append(Jumbotron(null));

            stringBuilder.Append(AddDetails(htmlpath, htmlpath + "images\\", "Wagons"));
            stringBuilder.Append(AddDetails(htmlpath, htmlpath + "images\\", "Loco"));
            stringBuilder.Append(AddDetails(htmlpath, htmlpath + "images\\", "Coach"));

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine(HTMLHelper.Modal());

            stringBuilder.Append("<script src='../Scripts/script.js'></script>");
            stringBuilder.Append("</body>");

            File.WriteAllText(htmlpath + "index.html", stringBuilder.ToString());
        }

        private static string AddDetails(string htmlpath, string imagePath, string name)
        {
            Directory.CreateDirectory(imagePath);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");

            stringBuilder.AppendLine($"<h2>{name}</h2>");

            string path = $@"F:\Trains\eWolfModelRailwayWeb\Data\Catalog\{name}";
            List<string> images = ImageHelper.GetAllImages(path);

            stringBuilder.AppendLine("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
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
                }
            }
            stringBuilder.AppendLine("</div></div>");
            return stringBuilder.ToString();
        }

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>Catalog</h1>");

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}
