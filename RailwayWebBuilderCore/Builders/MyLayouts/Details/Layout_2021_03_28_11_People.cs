using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_03_28_11_People : LayoutBase
    {
        public Layout_2021_03_28_11_People()
        {
            When = new DateTime(2021, 03, 28);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-03-28 11 People\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0328\\";

            Title = "<h2>People are arriving!</h2>";
            Details.Append("<p>Welcome back to Cattington, More people have arrived at Cattington</p>");
            Details.Append("<p>??</p>");
            Details.Append("<p>??</p>");

            YouTubeLink = "???";
        }
    }
}