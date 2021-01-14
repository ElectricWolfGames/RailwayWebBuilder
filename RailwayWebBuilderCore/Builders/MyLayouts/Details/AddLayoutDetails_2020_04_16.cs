using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2020_04_16 : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public AddLayoutDetails_2020_04_16()
        {
            When = new DateTime(2020, 04, 16);
            Details = new StringBuilder();

            RawImagePath = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\003-HillsAndTrack\";
            ExportImagePath = Constants.FullMyLayouts + "images\\003\\";

            Title = "<h2>It's been a while (Shelf display)</h2>";

            Details.Append("<p>Ok, I've final remembered to take some photo and upload them.</p>");
            Details.Append("<p>Here are some image of my Shelf display, it's just a static scene to have a nice place to put locos on and leave them on display.</p>");
            Details.Append("<p>next will be the bridge and track along the top.</p>");
        }
    }
}