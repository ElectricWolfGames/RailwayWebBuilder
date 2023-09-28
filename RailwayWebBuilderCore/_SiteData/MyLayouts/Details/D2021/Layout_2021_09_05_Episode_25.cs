using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_09_05_Episode_25 : LayoutBase
    {
        public Layout_2021_09_05_Episode_25()
        {
            Active = true;
            When = new DateTime(2021, 09, 05);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-09-05 25\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0905\\";

            Title = "<h2>25: Bridge and Track</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been doing a little more work on the bridge sections</p>");
            Details.Append("<p>Redone the track around Long Whiskers</p>");
            Details.Append("<p>And updated the layout around the shunting yard</p>");

            YouTubeLink = "UDDy0oma4nQ";
        }
    }
}