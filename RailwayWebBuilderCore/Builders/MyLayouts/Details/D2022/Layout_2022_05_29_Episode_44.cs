using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2022
{
    public class Layout_2022_05_29_Episode_44 : LayoutBase
    {
        public Layout_2022_05_29_Episode_44()
        {
            Active = true;
            When = new DateTime(2022, 05, 29);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-05-29 44\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220529\\";

            Title = "<h2>44: New Loco and more Vehicles</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>When we visited the Lutterworth Railway Society we picked up a new loco and some more vehicles.</p>");
            Details.Append("<p>Cadbury Castle with 3 Pullman for £85</p>");
            Details.Append("<p>Also done a little bit more work on the track</p>");
            Details.Append("<p>Track ballast and track side items added</p>");

            YouTubeLink = "XJp0uh4An7I";
        }
    }
}