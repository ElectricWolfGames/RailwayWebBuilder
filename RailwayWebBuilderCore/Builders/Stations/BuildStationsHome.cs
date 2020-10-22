using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using System.IO;
using System.Text;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsHome
    {
        public static void Build()
        {
            string htmlpath = Constants.Station;
            Directory.CreateDirectory(htmlpath);

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("index.html", htmlpath, new StationsHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../../"));
            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Append(Jumbotron(null));

            AddStationLoughboroughStation(pageBuilder);

            AddStationRushcliffeHalt(pageBuilder);

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLRailHelper.Modal());

            pageBuilder.Append("<script src='../../Scripts/script.js'></script>");

            pageBuilder.Output();
        }

        private static void AddStationRushcliffeHalt(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            pageBuilder.Append($"<hr/>");
            string path = "RushcliffeHalt/index.html";
            string name = "<h2>Rushcliffe Halt (GCRN)</h2>";
            pageBuilder.Append($"<a href='{path}'>{name}</a>");
        }

        private static void AddStationLoughboroughStation(eWolfBootstrap.Interfaces.IPageBuilder pageBuilder)
        {
            pageBuilder.Append($"<hr/>");
            string path = "LoughboroughStation/index.html";
            string name = "<h2>Loughborough Station (GCR)</h2>";
            pageBuilder.Append($"<a href='{path}'>{name}</a>");
        }

        private static string Jumbotron(IModelPageDetails pageDetails)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("<div class='jumbotron'>");
            stringBuilder.AppendLine("<div class='row'>");
            stringBuilder.AppendLine("<div class='col-md-4'>");
            stringBuilder.AppendLine($"<h1>Stations</h1>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");
            stringBuilder.AppendLine("</div>");

            return stringBuilder.ToString();
        }
    }
}
