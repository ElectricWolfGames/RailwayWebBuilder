using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details
{
    public class Layout_2024_01_14_Episode_61 : LayoutBase, IBlogger
    {
        public Layout_2024_01_14_Episode_61()
        {
            Active = true;
            When = new DateTime(2024, 01, 14);
            EpisodeNumber = 61;

            InitDatedPaths();

            Title = "<h2>61: New Loco and more wagons</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>We have picked up a new Class 03: Bachmann 31-361B D2028</p>");
            Details.Append("<p>And a selection of new wagons</p>");
            Details.Append("<p>also some extra items for the layout</p>");

            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "FU3RNhmX_Hg";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "New Loco and more wagons",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4981-thumb.JPG",
            };
        }
    }
}