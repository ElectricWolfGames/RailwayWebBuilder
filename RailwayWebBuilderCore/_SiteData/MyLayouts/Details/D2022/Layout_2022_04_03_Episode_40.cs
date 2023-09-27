using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022
{
    public class Layout_2022_04_03_Episode_40 : LayoutBase
    {
        public Layout_2022_04_03_Episode_40()
        {
            Active = true;
            When = new DateTime(2022, 04, 03);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-04-03 40\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220403\\";

            Title = "<h2>40: Donations and Embankment</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>We have received a few donations to add to our railway</p>");
            Details.Append("<p>And we wish to Thank</br>");
            Details.Append("Normal for the Loco,</br>");
            Details.Append("Nick for the road vehicles,</br>");
            Details.Append("Janice for the extra people</p>");

            Details.Append("<p>And a small update on the Embankment</p>");

            YouTubeLink = "6iqeu8CZvrw";
        }
    }
}