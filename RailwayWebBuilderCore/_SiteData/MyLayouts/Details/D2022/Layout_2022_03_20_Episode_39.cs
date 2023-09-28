using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022
{
    public class Layout_2022_03_20_Episode_39 : LayoutBase
    {
        public Layout_2022_03_20_Episode_39()
        {
            Active = true;
            When = new DateTime(2022, 03, 20);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-03-20 39\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220320\\";

            Title = "<h2>39: Embankment Update</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>We have been working on the embankment</p>");

            YouTubeLink = "mY6EoKLYSvk";
        }
    }
}