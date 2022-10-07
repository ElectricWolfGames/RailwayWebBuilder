using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_03_21_10_NewLoco : LayoutBase
    {
        public Layout_2021_03_21_10_NewLoco()
        {
            When = new DateTime(2021, 03, 21);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-03-21 10 New Loco\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0321\\";

            Title = "<h2>10: New Loco!</h2>";
            Details.Append("<p>Welcome back to Cattington, We have a new locomotive - Streamlined LMS Coronation Class - King George VI </p>");
            Details.Append("<p>We've built a farm/vicars house just over the railway line with, a bridge to access it.</p>");
            Details.Append("<p>And updated all the sidings</p>");

            YouTubeLink = "IADiT_1gxtA";
        }
    }
}