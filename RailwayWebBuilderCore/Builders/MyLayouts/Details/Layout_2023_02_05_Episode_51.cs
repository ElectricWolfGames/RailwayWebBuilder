using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2023_03_05_Episode_51 : LayoutBase
    {
        public Layout_2023_03_05_Episode_51()
        {
            Active = true;
            When = new DateTime(2023, 03, 05);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2023-03-05 51\";
            ExportImagePath = Constants.FullMyLayouts + "images\\230305\\";

            Title = "<h2>51: The Pond</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been adding Ballast to the update area</p>");
            Details.Append("<p>And worked on a tiny hill with a small poor of water.</p>");

            Details.Append("<p>And I've update the layout so the inner and outer trains have a link between them.</p>");

            YouTubeLink = "nQIU-XTothY";
        }
    }
}