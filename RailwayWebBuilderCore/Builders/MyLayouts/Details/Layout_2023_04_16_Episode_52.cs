using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2023_04_16_Episode_52 : LayoutBase
    {
        public Layout_2023_04_16_Episode_52()
        {
            Active = true;
            When = new DateTime(2023, 04, 16);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2023-04-16 52\";
            ExportImagePath = Constants.FullMyLayouts + "images\\230416\\";

            Title = "<h2>52: New Locos</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have two new locos</p>");
            Details.Append("<li>60025 A4 Falcon Train pack (3 coaches) R2794M : £110</li>");
            Details.Append("<li>D2428 Class 06 : £15</li>");
            Details.Append("</br>");

            Details.Append("<p>And worked a bit more on the lift out section</p>");

            YouTubeLink = "AsbpyHpiDWE";
        }
    }
}