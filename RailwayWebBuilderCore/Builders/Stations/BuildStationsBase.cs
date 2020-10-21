using eWolfBootstrap.Helpers;
using RailwayWebBuilderCore.Helpers;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Builders.Stations
{
    public class BuildStationsBase
    {
        protected static void AddImages(string htmlpath, string imagePath, eWolfBootstrap.Interfaces.IPageBuilder pageBuilder, string path)
        {
            List<string> images = ImageHelper.GetAllImages(path);
            pageBuilder.Append("<div class='container mt-4'><div class='row'>");
            int count = 2;
            foreach (string layoutImage in images)
            {
                if (images.Contains(layoutImage))
                {
                    eWolfBootstrap.Helpers.HTMLHelper.AddImageToPage(htmlpath, imagePath, pageBuilder, layoutImage);
                    if (count-- == 0)
                    {
                        count = 2;
                        pageBuilder.Append("</div></div>");
                        pageBuilder.Append("<div class='container mt-4'><div class='row'>");
                    }
                }
            }
            pageBuilder.Append("</div></div>");
        }
    }
}
