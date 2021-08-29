using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_09_05_Episode_25 : LayoutBase
    {
        public Layout_2021_09_05_Episode_25()
        {
            Active = true;
            When = new DateTime(2021, 09, 05);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-09-05 25\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0909\\";

            Title = "<h2>Update 25!</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            YouTubeLink = "?????";
        }
    }
}