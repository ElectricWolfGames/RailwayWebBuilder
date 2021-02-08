using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_02_07_Town_Layout : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public Layout_2021_02_07_Town_Layout()
        {
            When = new DateTime(2021, 02, 07);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-07 Town Layout\";
            ExportImagePath = Constants.FullMyLayouts + "images\\011\\";

            Title = "<h2>Change of layout and town update!</h2>";

            Details.Append("<p>We have moved things around now,</p>");
            Details.Append("<p>So the station has moved, this will now be next to Cattington Town.</p>");
            Details.Append("<p>This lets us move the engine depot around and have a large shunting yard.</p>");
            Details.Append("<p>We have also placed the village inn and a church.</p>");

            YouTubeLink = "g6PCwGARk78";
        }
    }
}