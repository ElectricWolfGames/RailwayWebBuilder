using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;
using RailwayWebBuilderCore.Builders.MyLayouts.Details;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_05_16_Episode_17 : LayoutBase
    {
        public Layout_2021_05_16_Episode_17()
        {
            Active = true;
            When = new DateTime(2021, 05, 16);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-05-16 17 Castle\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0516\\";

            Title = "<h2>17: Castle Tyson</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>We have been busy, Added a backscene, Built a Castle, update the yard near the station and changed the layout of the shuttering area and Added some more sheep!</p>");

            YouTubeLink = "jye5SJr5-6A";
        }
    }
}
