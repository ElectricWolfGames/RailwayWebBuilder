using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2022_01_23_Episode_35 : LayoutBase
    {
        public Layout_2022_01_23_Episode_35()
        {
            Active = true;
            When = new DateTime(2022, 01, 23);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-01-23 35\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220123\\";

            Title = "<h2>35: Room Tour</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>As Cattington is now one year old, we are going to do a full room tour.</p>");
            
            YouTubeLink = "dMpE5xa2-IA";
        }
    }
}