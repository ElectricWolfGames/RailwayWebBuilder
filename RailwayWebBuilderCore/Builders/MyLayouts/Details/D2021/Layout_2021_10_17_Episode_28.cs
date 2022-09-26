using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;
using RailwayWebBuilderCore.Builders.MyLayouts.Details;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_10_17_Episode_28 : LayoutBase
    {
        public Layout_2021_10_17_Episode_28()
        {
            Active = true;
            When = new DateTime(2021, 10, 17);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-10-17 28\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1017\\";

            Title = "<h2>28: New Wagons, New Steam shovel And Update building</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>After visiting a show we pick up some new ore wagons £15 for 3</p>");
            Details.Append("<p>A very nice steam shovel for £9:50</p>");
            Details.Append("<p>and we picked up a few other small items</p>");

            Details.Append("<p>And we have been donated some bikes and a small building</p>");

            YouTubeLink = "p60rx1U94rE";
        }
    }
}
