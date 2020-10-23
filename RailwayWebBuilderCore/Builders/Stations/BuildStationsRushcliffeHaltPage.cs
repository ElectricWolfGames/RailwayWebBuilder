using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsRushcliffeHaltPage : BuildStationsBase
    {
        public static void Build()
        {
            string htmlpath = Constants.RushcliffeHalt;
            Directory.CreateDirectory(htmlpath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, new StationsHeader(), "../../");

            pageBuilder.Append(NavBarHelper.NavBar("../../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Append(Jumbotron(null));

            pageBuilder.Append(AddHalt_001(htmlpath, htmlpath + "images\\"));

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLRailHelper.Modal());

            pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            pageBuilder.Output();
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

            var pageBuilder = new PageBuilder();

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>First trip to Rushcliffe Halt featuring a class 66</h2> 26/06/2020");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\Stations\Rushcliffe Halt\2020-06-26\";

            pageBuilder.Append("<div class='col-md-8'>");
            string youTubeLink = "https://www.youtube.com/embed/NemRaAwWhms";

            pageBuilder.Append("<div class='embed-responsive embed-responsive-16by9'>");
            pageBuilder.Append($"<iframe src='{youTubeLink}' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>");
            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.AddImages(htmlpath, imagePath, path);

            return pageBuilder.GetString();
        }
    }
}
