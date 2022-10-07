using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_04_17_Week_14 : LayoutBase
    {
        public Layout_2021_04_17_Week_14()
        {
            When = new DateTime(2021, 04, 17);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-04-17 Week 14\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0417\\";

            Title = "<h2>14: New Rolling Stock and Chickens</h2>";
            Details.Append("<p>Welcome back to Cattington, We have been shopping and picked up some new rolling stock and other things.</p>");
            Details.Append("<p>All from a second hand shop</p>");

            Details.Append("<strong>Micks Toys</strong>");
            Details.Append("<p>Windsor St, Melton Mowbray LE13 1BU</p>");

            YouTubeLink = "WrIqtvGHJmY";
        }
    }
}