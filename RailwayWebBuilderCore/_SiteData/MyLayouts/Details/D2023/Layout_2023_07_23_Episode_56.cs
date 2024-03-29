﻿using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023
{
    public class Layout_2023_07_23_Episode_56 : LayoutBase, IBlogger
    {
        public Layout_2023_07_23_Episode_56()
        {
            Active = true;
            When = new DateTime(2023, 07, 23);
            EpisodeNumber = 56;

            InitDatedPaths();

            Title = "<h2>56: Small Coaches and Standard Class 4MT and 5MT</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>More work on the track near long whiskers and the fiddle Yard.</p>");
            Details.Append("<p>This week we have 3 guest locos, 4MT and 5MT</p>");
            Details.Append("<ul>");
            Details.Append("<li>31-115k Standard Class 4MT 75075 BR Black Late Crest  (Weathered) Bachmann club</li>");
            Details.Append("<li>31-108 Standard Class 4MT 75063 BR Lined Black E/Emblem BR18 Tender Weathered</li>");
            Details.Append("<li>32-509 Standard Class 5MT 73109 BR Black Early Emblem</li>");
            Details.Append("</ul>");

            Details.Append("<p>We also show some more small 4 wheel Coaches (Hornby)</p>");

            Details.Append("</br>");

            YouTubeLink = "kXDVM__zz3g";
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = $"Cattington Update {EpisodeNumber}",
                Date = When,
                Link = "MyLayouts/index.html",
                Paragraph = "Small Coaches and Standard Class 4MT and 5MT",
                KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4167-Cattington-thumb.JPG",
            };
        }
    }
}