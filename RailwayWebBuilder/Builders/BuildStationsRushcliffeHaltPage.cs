using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Data;
using RailwayWebBuilder.Helpers;
using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RailwayWebBuilder.Builders
{
    public class BuildStationsRushcliffeHaltPage
    {
        public static void Build(IModelEvent pageDetails)
        {
            string htmlpath = Constants.RushcliffeHalt;
            Directory.CreateDirectory(htmlpath);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(PageHeaderHelper.PageHeader(new StationsHeader()));
            stringBuilder.Append("<body>");
            stringBuilder.Append(NavBarHelper.NavBar("../../"));
            stringBuilder.AppendLine("<div class='container mt-4'>");
            stringBuilder.Append(Jumbotron(null));

            stringBuilder.Append(AddHalt_001(htmlpath, htmlpath + "images\\"));

            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            stringBuilder.AppendLine(HTMLHelper.Modal());

            stringBuilder.Append("<script src='../../Scripts/script.js'></script>");
            stringBuilder.Append("</body>");

            File.WriteAllText(htmlpath + "index.html", stringBuilder.ToString());
        }

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>Rushcliffe Halt</h1>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

        private static string AddHalt_001(string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"<hr/>");
            stringBuilder.AppendLine("<h2>First trip to Rushcliffe Halt featuring a class 66</h2> 26/06/2020");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\Stations\Rushcliffe Halt\2020-06-26\";

            stringBuilder.AppendLine("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/NemRaAwWhms";

            stringBuilder.AppendLine("<div class='embed-responsive embed-responsive-16by9'>");
            stringBuilder.AppendLine($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

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
    }
}
