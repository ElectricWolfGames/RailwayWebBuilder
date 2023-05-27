using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2023_05_28_Episode_53 : LayoutBase
    {
        public Layout_2023_05_28_Episode_53()
        {
            Active = true;
            When = new DateTime(2023, 05, 28);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2023-05-28 53\";
            ExportImagePath = Constants.FullMyLayouts + "images\\230528\\";

            Title = "<h2>53: The Signal Box and Sounds</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>I've been gluing some track down and also done a bit extra work near the single box.</p>");
            Details.Append("<p>Also did some sound tests using cardboard to reduce some of the baseboards.</p>");
            Details.Append("</br>");

            YouTubeLink = "d7nfRrZ0Otk";
        }
    }
}