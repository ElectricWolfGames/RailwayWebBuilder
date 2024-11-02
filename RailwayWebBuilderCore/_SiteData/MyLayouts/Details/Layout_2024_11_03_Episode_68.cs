using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details
{
    public class Layout_2024_11_03_Episode_68 : LayoutBase, IBlogger
    {
        public Layout_2024_11_03_Episode_68()
        {
            Active = true;
            When = new DateTime(2024, 11, 03);
            EpisodeNumber = 68;

            InitDatedPaths();

            Title = "<h2>68: Station, Station, room and Town</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>We have updated both Stations</p>");
            Details.Append("<p>I had to fix some track problems</p>");
            Details.Append("<p>Added a new building to cattington town.</p>");

            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "4Kvk5HYJPdA";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "Station, Station, room and Town",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_7610-Cattington-thumb.JPG",
            };
        }
    }
}