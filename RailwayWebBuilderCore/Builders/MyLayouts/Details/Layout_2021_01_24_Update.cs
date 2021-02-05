using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_01_24_Update_Name : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public Layout_2021_01_24_Update_Name()
        {
            When = new DateTime(2021, 01, 24);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-01-24 Update\";
            ExportImagePath = Constants.FullMyLayouts + "images\\010\\";

            Title = "<h2>Name and update</h2>";

            Details.Append("<p>We have named our layout - watch to find out...</p>");
            Details.Append("<p>And some other update around the boards before we can do anything else.</p>");

            YouTubeLink = "NvHYQiO52n8";
        }
    }
}