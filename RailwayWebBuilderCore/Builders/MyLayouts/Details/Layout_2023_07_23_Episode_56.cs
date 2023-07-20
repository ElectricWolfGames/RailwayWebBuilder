using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2023_07_23_Episode_56 : LayoutBase, IBlogger
    {
        public Layout_2023_07_23_Episode_56()
        {
            Active = true;
            When = new DateTime(2023, 07, 23);
            EpisodeNumber = 56;

            InitDatedPaths();

            Title = "<h2>56: Br Days!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>More work on the track near long whiskers and the fiddle Yard.</p>");
            Details.Append("<p>This weeks Guset locos are 2 Standard MT4, and a Standard 5MT</p>");
            Details.Append("<p></p>");
            Details.Append("<p></p>");

            Details.Append("</br>");

            YouTubeLink = "";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4107-thumb.JPG",
            };
        }
    }
}