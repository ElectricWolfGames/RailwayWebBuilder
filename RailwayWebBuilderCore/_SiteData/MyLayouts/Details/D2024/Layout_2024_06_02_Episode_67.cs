using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2024
{
    public class Layout_2024_06_02_Episode_67 : LayoutBase, IBlogger
    {
        public Layout_2024_06_02_Episode_67()
        {
            Active = true;
            When = new DateTime(2024, 06, 02);
            EpisodeNumber = 67;

            InitDatedPaths();

            Title = "<h2>67: Hill, Wagons and a crane</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>I've got an update on the hill to show you.</p>");
            Details.Append("<p>Two amazing wagons </p>");
            Details.Append("<p>And a friend of mine has kindly weathered one of my cranes</p>");

            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "rmBt3GpyFs0";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "Hill, Wagons and a crane",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_6371-thumb.JPG",
            };
        }
    }
}