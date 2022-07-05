using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2022
{
    public class Layout_2022_06_26_Episode_46 : LayoutBase
    {
        public Layout_2022_06_26_Episode_46()
        {
            Active = false;
            When = new DateTime(2022, 06, 26);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-06-26 46\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220626\\";

            Title = "<h2>46: New Loco!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have a new Loco a 'Q1' This was a very kind gift form Nick</p>");

            YouTubeLink = "??";
        }
    }
}