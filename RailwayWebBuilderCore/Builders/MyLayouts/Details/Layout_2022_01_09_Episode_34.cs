using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2022_01_09_Episode_34 : LayoutBase
    {
        public Layout_2022_01_09_Episode_34()
        {
            Active = false;
            When = new DateTime(2022, 01, 09);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-01-09 34\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220109\\";

            Title = "<h2>34: Happy New Year!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have a new Loco, Some new rolling stock</p>");
            Details.Append("<p>And we have been adding some ballast</p>");

            YouTubeLink = "missing";
        }
    }
}
