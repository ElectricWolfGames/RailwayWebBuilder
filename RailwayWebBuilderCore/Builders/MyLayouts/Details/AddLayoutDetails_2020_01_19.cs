using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2020_01_19 : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public AddLayoutDetails_2020_01_19()
        {
            When = new DateTime(2020, 01, 19);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\001-Track Ideas\";
            ExportImagePath = Constants.FullMyLayouts + "images\\001\\";

            Title = "<h2>Layout ideas(Shunting yard)</h2>";

            Details.Append("<p>For the Shunting yard, I played around with many track layouts, just by laying track down on the surface to see how it will look.</p>");
            Details.Append("<p>Here are some of them...</p>");
        }
    }
}