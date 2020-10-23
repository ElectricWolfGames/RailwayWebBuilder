using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class LocomotiveDetailsBuilder
    {
        public (string, string) GetPagePath
        {
            get
            {
                string htmlpath = Constants.RootPath + "//" + Constants.Locomotive + "//";
                string fileName = "LocomotiveDetails.html";

                (string path, string fileName) path = (htmlpath, fileName);
                return path;
            }
        }

        public void Build()
        {
            (string path, string fileName) = GetPagePath;

            var pageBuilder = new PageBuilder(fileName, path, new AllLocosDetailsHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));

            pageBuilder.Append("<div class='container mt-4'>");
            pageBuilder.Jumbotron("<h1>Locomotive Details</h1>", "<p>Collection of stats, details and tables comparing different stream locomotive</p>");

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Append(HTMLRailHelper.Modal());

            pageBuilder.Append("<script src='../Scripts/script.js'></script>");

            pageBuilder.Output();
        }
    }
}
