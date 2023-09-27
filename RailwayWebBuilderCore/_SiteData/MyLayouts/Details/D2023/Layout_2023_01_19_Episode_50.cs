using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023
{
    public class Layout_2023_01_19_Episode_50 : LayoutBase
    {
        public Layout_2023_01_19_Episode_50()
        {
            Active = true;
            When = new DateTime(2023, 01, 19);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2023-01-19 50\";
            ExportImagePath = Constants.FullMyLayouts + "images\\230119\\";

            Title = "<h2>50: Fixed Loco and new Building</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have fixed the Heljan Class 07 :)</p>");
            Details.Append("<p>And we have some New Building</p>");

            YouTubeLink = "wwM6hwSbAos";
        }
    }
}