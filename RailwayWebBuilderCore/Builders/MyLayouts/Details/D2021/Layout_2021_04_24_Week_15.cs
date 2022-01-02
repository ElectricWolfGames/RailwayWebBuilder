using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_04_24_Week_15 : LayoutBase
    {
        public Layout_2021_04_24_Week_15()
        {
            When = new DateTime(2021, 04, 24);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-04-24 Week 15\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0424\\";

            Title = "<h2>15: Back in the 1970s</h2>";
            Details.Append("<p>Welcome back to Cattington, We have a selection of rolling stock from the 1970s</p>");
            Details.Append("<p>Stock I would have played with when I was very young.</p>");

            YouTubeLink = "Zoc_VWC_dgI";
        }
    }
}