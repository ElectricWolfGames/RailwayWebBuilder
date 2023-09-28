using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_06_26_Episode_20 : LayoutBase
    {
        public Layout_2021_06_26_Episode_20()
        {
            Active = true;
            When = new DateTime(2021, 06, 26);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-06-26 20\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0626\\";

            Title = "<h2>20: Tunnel and layout</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been changing the track and points again</p>");
            Details.Append("<p>Started work on the 3rd tunnel entrance and some work for the corner where some more house and road are going.</p>");

            YouTubeLink = "6xhWTs5osyU";
        }
    }
}