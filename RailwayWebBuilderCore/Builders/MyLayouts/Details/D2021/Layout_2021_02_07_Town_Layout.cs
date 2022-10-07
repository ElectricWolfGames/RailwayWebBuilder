using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_02_07_Town_Layout : LayoutBase
    {
        public Layout_2021_02_07_Town_Layout()
        {
            When = new DateTime(2021, 02, 07);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-07 Town Layout\";
            ExportImagePath = Constants.FullMyLayouts + "images\\011\\";

            Title = "<h2>04: Change of layout and town update!</h2>";

            Details.Append("<p>We have moved things around now,</p>");
            Details.Append("<p>So the station has moved, this will now be next to Cattington Town.</p>");
            Details.Append("<p>This lets us move the engine depot around and have a large shunting yard.</p>");
            Details.Append("<p>We have also placed the village inn and a church.</p>");

            YouTubeLink = "g6PCwGARk78";
        }
    }
}