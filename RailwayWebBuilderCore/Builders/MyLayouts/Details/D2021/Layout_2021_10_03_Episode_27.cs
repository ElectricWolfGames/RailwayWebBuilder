using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_10_03_Episode_27 : LayoutBase
    {
        public Layout_2021_10_03_Episode_27()
        {
            Active = true;
            When = new DateTime(2021, 10, 03);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-10-03 27\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1003\\";

            Title = "<h2>27: New Garden</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been adding the garden to the top part of Long Whiskers</p>");
            Details.Append("<p>Also started work on the industrial building for the back ground</p>");

            YouTubeLink = "lWV-22vfTqw";
        }
    }
}