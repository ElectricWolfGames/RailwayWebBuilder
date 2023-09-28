using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022
{
    public class Layout_2022_08_07_Episode_46 : LayoutBase
    {
        public Layout_2022_08_07_Episode_46()
        {
            Active = true;
            When = new DateTime(2022, 08, 07);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-08-07 46\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220807\\";

            Title = "<h2>46: New Loco and Factory update!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have a new Loco a 'Q1' This was a very kind gift from Nick</p>");
            Details.Append("<p>Update on some of the track and a big update around the factory area</p>");

            YouTubeLink = "Eukp3lZu7b4";
        }
    }
}