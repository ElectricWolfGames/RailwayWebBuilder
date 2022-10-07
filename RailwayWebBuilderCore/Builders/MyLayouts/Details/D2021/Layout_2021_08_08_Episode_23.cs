using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_08_08_Episode_23 : LayoutBase
    {
        public Layout_2021_08_08_Episode_23()
        {
            Active = true;
            When = new DateTime(2021, 08, 08);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-08-08 23\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0808\\";

            Title = "<h2>23: Low relief building and a new loco</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>Just added the low relief building to the corner section</p>");
            Details.Append("<p>And we have a new loco, It's a DMU 110, our first diesel</p>");

            Details.Append("<p>Hornby R2297A class 110 3 car Calder Vale DMU in BR green.</p>");
            Details.Append("<p>Picked up from the Emporium at GCR Loughborough Station.</p>");

            YouTubeLink = "71ocMjS2hi4";
        }
    }
}