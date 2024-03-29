﻿using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_03_07_08_Station : LayoutBase
    {
        public Layout_2021_03_07_08_Station()
        {
            When = new DateTime(2021, 03, 07);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-03-07 08 Station\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0307\\";

            Title = "<h2>08: Station and new people</h2>";

            Details.Append("<p>We have completed the station platforms, and we have weathered the track</p>");
            Details.Append("<p>And we have also been painting some people to use in the town.</p>");

            YouTubeLink = "qPkuPZ664T8";
        }
    }
}