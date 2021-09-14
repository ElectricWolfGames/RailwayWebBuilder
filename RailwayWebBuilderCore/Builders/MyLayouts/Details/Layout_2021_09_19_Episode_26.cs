using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_09_19_Episode_26 : LayoutBase
    {
        public Layout_2021_09_19_Episode_26()
        {
            Active = true;
            When = new DateTime(2021, 09, 19);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-09-19 26\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0919\\";

            Title = "<h2>Layout and Backscene</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have added a backscene to the Long Whiskers side of the railway</p>");
            Details.Append("<p>And also changed the layout again, so now Long Whiskers can be seen more, and looks more like a station.</p>");

            YouTubeLink = "";
        }
    }
}