using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023
{
    public class Layout_2023_01_02_Episode_49 : LayoutBase
    {
        public Layout_2023_01_02_Episode_49()
        {
            Active = true;
            When = new DateTime(2023, 01, 02);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2023-01-02 49\";
            ExportImagePath = Constants.FullMyLayouts + "images\\230102\\";

            Title = "<h2>49: New Loco and layout update</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>I've fixed the access panel into the layout, so I hope to have fewer derailing trains.</p>");
            Details.Append("<p>also a new Loco</p>");
            Details.Append("<p>Battle of Britian Class: Spitfire - 21C166 : Hornby R374</p>");

            YouTubeLink = "XtlI8mBnO70";
        }
    }
}