using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsLoughboroughStationPage : BuildStationsBase
    {
        public static void Build()
        {
            string htmlpath = Constants.LoughboroughStation;
            Directory.CreateDirectory(htmlpath);

            var pageBuilder = new PageBuilder("index.html", htmlpath, new StationsHeader(), "../../");

            pageBuilder.Append(NavBarHelper.NavBar("../../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Append(Jumbotron(null));

            AddLoughborough_001(pageBuilder, htmlpath, htmlpath + "images\\");

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
            stringBuilder.AppendLine($"<h1>Loughborough Station</h1>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }

        private static void AddLoughborough_001(PageBuilder pageBuilder, string htmlpath, string imagePath)
        {
            Directory.CreateDirectory(imagePath);

            pageBuilder.Append($"<hr/>");
            pageBuilder.Append("<h2>Loughborough Station viewed from a far</h2> 17 and 18/10/2020");

            string path = @"F:\Trains\eWolfModelRailwayWeb\Data\Stations\Loughborough Station\2020-10-17\";
            pageBuilder.AddImages(htmlpath, imagePath, path);
        }
    }
}
