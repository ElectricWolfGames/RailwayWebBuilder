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

    public class Layout_2024_02_18_Episode_63 : LayoutBase, IBlogger
    {
        public Layout_2024_02_18_Episode_63()
        {
            Active = true;
            When = new DateTime(2024, 02, 18);
            EpisodeNumber = 63;

            InitDatedPaths();

            Title = "<h2>63: Time for the Hill to go!</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>I'll be removing the hill, this is letting me change some of the layout</p>");
            Details.Append("<p>this also allows us to add in some extra sidings.</p>");
            Details.Append("<p>And a big thanks to Steve for the new Cattington Mugs.</p>");

            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "Hill no more",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_5350-Cattington-thumb.JPG",
            };
        }
    }
}