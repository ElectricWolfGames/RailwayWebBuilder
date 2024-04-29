using RailwayWebBuilderCore.Data; using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details
{
    public class Layout_2023_12_10_Episode_60 : LayoutBase, IBlogger
    {
        public Layout_2023_12_10_Episode_60()
        {
            Active = true;
            When = new DateTime(2023, 12, 10);
            EpisodeNumber = 60;

            InitDatedPaths();

            Title = "<h2>60: 6 9Fs - going to need a bigger layout!</h2>";
            Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
            Details.Append("</br>");
            Details.Append("<p>This time we have 6 9F on the layout to take a look at.</p>");

            Details.Append("</br>");
            Details.Append("<ul>");
            Details.Append("<li>R3987 Late BR Class 9F 92194 (Hornby)</li>");
            Details.Append("<li>R3274 BR (late) Class 9F Crosti Boiler 92023 (Hornby)</li>");
            Details.Append("<li>32-854 9F 92079 BR1G Tender BR Early Emblem Lickey Banker (Bachmann)</li>");
            Details.Append("<li>32-850 9F 92214 BR1G Tender (Bachmann)</li>");
            Details.Append("<li>32-585 9F 92189 late crest (Weathered) (Bachmann)</li>");
            Details.Append("</ul>");
            Details.Append("</br>");
            Details.Append("</br>");
            Details.Append("</br>");
            Details.Append("<p>Thank you for watching, Take care</p>");
            YouTubeLink = "fERl790hBfE";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "we have 6 9fs on the layout!",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4981-thumb.JPG",
            };
        }
    }
}