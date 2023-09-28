using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022
{
    public class Layout_2022_05_15_Episode_43 : LayoutBase
    {
        public Layout_2022_05_15_Episode_43()
        {
            Active = true;
            When = new DateTime(2022, 05, 15);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-05-15 43\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220515\\";

            Title = "<h2>43: New Vehicles</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We picked up new vehicles form the Bus rally at GCR</p>");
            Details.Append("<p>And we have glued more tracks down!</p>");

            YouTubeLink = "cSCFYroQ0bI";
        }
    }
}