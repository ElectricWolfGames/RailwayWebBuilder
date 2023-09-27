using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022
{
    public class Layout_2022_01_09_Episode_34 : LayoutBase
    {
        public Layout_2022_01_09_Episode_34()
        {
            Active = true;
            When = new DateTime(2022, 01, 09);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-01-09 34\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220109\\";

            Title = "<h2>34: Happy New Year!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have clean-up some old locos</p>");
            Details.Append("<p>And we have some new livestock.</p>");

            YouTubeLink = "B-Pv3PvYkw0";
        }
    }
}