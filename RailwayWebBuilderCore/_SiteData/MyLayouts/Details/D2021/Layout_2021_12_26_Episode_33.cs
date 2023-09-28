using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_12_26_Episode_33 : LayoutBase
    {
        public Layout_2021_12_26_Episode_33()
        {
            Active = true;
            When = new DateTime(2021, 12, 26);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-12-26 33\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1226\\";

            Title = "<h2>33: New Loco, More Coaches And Ballast</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have a new Loco, Some new rolling stock</p>");
            Details.Append("<p>And we have been adding some ballast</p>");

            YouTubeLink = "nuVrC6OXSDY";
        }
    }
}