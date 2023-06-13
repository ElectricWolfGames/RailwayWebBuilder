using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2023_06_18_Episode_54 : LayoutBase
    {
        public Layout_2023_06_18_Episode_54()
        {
            Active = true;
            When = new DateTime(2023, 06, 18);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2023-06-18 54\";
            ExportImagePath = Constants.FullMyLayouts + "images\\230618\\";

            Title = "<h2>54: The Signal Box, Guest Loco and the Funfair</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>More work on the signal box, Fixed the steps.</p>");
            Details.Append("<p>An A5 makes a guest appearance</p>");
            Details.Append("<p>The funfair arrives at cattington</p>");
            Details.Append("</br>");

            YouTubeLink = "???????";
        }
    }
}