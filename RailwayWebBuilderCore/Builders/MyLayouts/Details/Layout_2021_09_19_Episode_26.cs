using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_09_19_Episode_26 : LayoutBase
    {
        public Layout_2021_09_19_Episode_26()
        {
            Active = false;
            When = new DateTime(2021, 09, 19);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-09-19 26\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0919\\";

            Title = "<h2>Bridge and Track</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been doing a little more work on the bridge sections</p>");
            Details.Append("<p>Redone the track around Long Whiskers</p>");
            Details.Append("<p>And updated the layout around the shunting yard</p>");

            YouTubeLink = "UDDy0oma4nQ";
        }
    }
}