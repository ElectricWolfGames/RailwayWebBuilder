using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_01_31_Town : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public Layout_2021_01_31_Town()
        {
            When = new DateTime(2021, 01, 31);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-01-31 Town\";
            ExportImagePath = Constants.FullMyLayouts + "images\\011\\";

            Title = "<h2>Updating the Town</h2>";

            Details.Append("<p>We have started to work on the town</p>");
            //Details.Append("<p>And some other update around the boards before we can do anything else.</p>");

            YouTubeLink = "ozEH8lHAAH8";
        }
    }
}