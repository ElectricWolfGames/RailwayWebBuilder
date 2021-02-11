using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_02_14_StuckRails_Church : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public Layout_2021_02_14_StuckRails_Church()
        {
            When = new DateTime(2021, 02, 14);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-14 StuckRails Church\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0214\\";

            Title = "<h2>Stuck done some track and updated the Church</h2>";

            Details.Append("<p>We have started to glue the track down, currently I don't have enought cork to finish the work.</p>");
            Details.Append("<p>But at least I've been able to get one track on to the swing out section.</p>");

            Details.Append("<p>And we have added the scenery around the church</p>");

            YouTubeLink = "????????";
        }
    }
}