using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023
{
    public class Layout_2023_09_03_Episode_58 : LayoutBase, IBlogger
    {
        public Layout_2023_09_03_Episode_58()
        {
            Active = true;
            When = new DateTime(2023, 09, 03);
            EpisodeNumber = 58;

            InitDatedPaths();

            Title = "<h2>58: New Loco, New Coaches, Updated Scenery</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have done some more trackwork around long whiskers</p>");
            Details.Append("<p>We also show some rolling stock we recently picked up</p>");
            Details.Append("</br>");

            YouTubeLink = "JXeKKY-gTDo";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "New Loco, New Coaches, Updated Scenery",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4595-thumb.JPG",
            };
        }
    }
}