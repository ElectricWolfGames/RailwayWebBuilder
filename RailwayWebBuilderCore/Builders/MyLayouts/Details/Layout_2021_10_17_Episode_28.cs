using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_10_17_Episode_28 : LayoutBase
    {
        public Layout_2021_10_17_Episode_28()
        {
            Active = false;
            When = new DateTime(2021, 10, 17);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-10-17 28\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1017\\";

            Title = "<h2>28: New Wagons, New Steam shovel and more people</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>After visiting a show we pickup some new ore wagons £15 for 3</p>");
            Details.Append("<p>A very nice steam shovel for £9:50</p>");
            Details.Append("<p>and we picked up a few other small items</p>");

            Details.Append("<p>And we have been given some more bikes to use around the town</p>");

            YouTubeLink = "?????";
        }
    }
}
