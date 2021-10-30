using System;
using System.Text;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
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

    public class Layout_2021_10_31_Episode_29 : LayoutBase
    {
        public Layout_2021_10_31_Episode_29()
        {
            Active = true;
            When = new DateTime(2021, 10, 31);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-10-31 29\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1031\\";

            Title = "<h2>29: More bargains</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>Picked up a few bargains from the Emporium at GCR Loughborough Station.</p>");
            
            YouTubeLink = "???";
        }
    }
}
