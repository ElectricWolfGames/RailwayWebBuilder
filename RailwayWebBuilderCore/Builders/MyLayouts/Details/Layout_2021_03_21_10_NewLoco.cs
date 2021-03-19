using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_03_21_10_NewLoco : LayoutBase
    {
        public Layout_2021_03_21_10_NewLoco()
        {
            When = new DateTime(2021, 03, 21);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-03-21 10 New Loco\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0321\\";

            Title = "<h2>New Loco!</h2>";
            Details.Append("<p>Welcome to cattington town, Have a new locomotive - Streamlined LMS Coronation Class - King George VI </p>");
            Details.Append("<p>And we have build a vicars house just over the railway line</p>");

            YouTubeLink = "??????";
        }
    }
}