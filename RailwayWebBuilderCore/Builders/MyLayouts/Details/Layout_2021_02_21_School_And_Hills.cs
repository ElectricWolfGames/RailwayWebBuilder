using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_02_21_School_And_Hills : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public Layout_2021_02_21_School_And_Hills()
        {
            When = new DateTime(2021, 02, 21);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-21 School and hills\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0221\\";

            Title = "<h2>Church, School and hills</h2>";

            Details.Append("<p>The Church and School are in place, with the surrounding areas detailed.</p>");
            Details.Append("<p>More work on the large hill in the corner.</p>");
            Details.Append("<p>And we have made the main railway station just need to add some platforms to it.</p>");

            Details.Append("<p>Wok around the swing section is going ok, and the first trains are now running across it again.</p>");

            YouTubeLink = "N_kww5HqtBk";
        }
    }
}