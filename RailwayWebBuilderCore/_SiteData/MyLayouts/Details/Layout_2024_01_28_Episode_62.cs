using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details
{
    public class Layout_2024_01_28_Episode_62 : LayoutBase, IBlogger
    {
        public Layout_2024_01_28_Episode_62()
        {
            Active = true;
            When = new DateTime(2024, 01, 28);
            EpisodeNumber = 62;

            InitDatedPaths();

            Title = "<h2>62: Full Layout tour</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>Today I would like to show you around the layout</p>");
            Details.Append("<p>The layout is 9 by 8 feet</p>");
            Details.Append("<p>And it's now 3 years old.</p>");

            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "Wi4SWrfwcxQ";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "Full layout tour",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_5305-thumb.JPG",
            };
        }
    }
}