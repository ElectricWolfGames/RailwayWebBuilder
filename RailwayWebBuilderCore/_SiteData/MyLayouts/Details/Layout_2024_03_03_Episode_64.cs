using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details
{
    public class Layout_2024_03_03_Episode_64 : LayoutBase, IBlogger
    {
        public Layout_2024_03_03_Episode_64()
        {
            Active = true;
            When = new DateTime(2024, 03, 03);
            EpisodeNumber = 64;

            InitDatedPaths();

            Title = "<h2>64: New Car Park</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>I've added a new car pack next to the main station.</p>");
            Details.Append("<p>Keep an eye out as I've got two guest locos in the Running session, Can you spot them, Comment below.</p>");

            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "h6ndFEHx9Mg";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "New Car Park!",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_5410-Cattington-thumb.JPG",
            };
        }
    }
}