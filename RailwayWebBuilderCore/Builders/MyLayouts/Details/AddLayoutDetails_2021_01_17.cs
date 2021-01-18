using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2021_01_17 : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public AddLayoutDetails_2021_01_17()
        {
            When = new DateTime(2021, 01, 17);
            Details = new StringBuilder();

            RawImagePath = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\MyLayout\2021-01-17 First Fixedlayout\";
            ExportImagePath = Constants.FullMyLayouts + "images\\009\\";

            Title = "<h2>Started our fixed layout</h2>";

            Details.Append("<p>We have our base boards and we have just finished building them in our spare bedroom.</p>");

            YouTubeLink = "nZ64DxtbbNQ";
        }
    }
}