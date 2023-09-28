using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022
{
    public class Layout_2022_10_07_Episode_47 : LayoutBase
    {
        public Layout_2022_10_07_Episode_47()
        {
            Active = true;
            When = new DateTime(2022, 10, 07);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-10-07 47\";
            ExportImagePath = Constants.FullMyLayouts + "images\\221007\\";

            Title = "<h2>47: Fixing Track and New Wagons</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have fixed a part of the track that has been a problem for a long time.</p>");
            Details.Append("<p>Also got in some more new wagons.</p>");
            Details.Append("<p>And a small update on the factory.</p>");

            YouTubeLink = "x4dY4979Rsc";
        }
    }
}