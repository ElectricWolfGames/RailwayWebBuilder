using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_12_26_Episode_33 : LayoutBase
    {
        public Layout_2021_12_26_Episode_33()
        {
            Active = false;
            When = new DateTime(2021, 12, 26);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-12-26 33\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1226\\";

            Title = "<h2>31: Locos at Cattington</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>Lets take a look at all the loco we have.</p>");

            YouTubeLink = "";
        }
    }
}