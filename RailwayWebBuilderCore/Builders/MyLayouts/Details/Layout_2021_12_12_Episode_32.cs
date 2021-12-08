using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_12_12_Episode_32 : LayoutBase
    {
        public Layout_2021_12_12_Episode_32()
        {
            Active = false;
            When = new DateTime(2021, 12, 12);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-12-12 32\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1212\\";

            Title = "<h2>31: Locos at Cattington</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>Lets take a look at all the loco we have.</p>");

            YouTubeLink = "";
        }
    }
}