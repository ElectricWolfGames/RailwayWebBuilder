using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2021_01_01 : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public AddLayoutDetails_2021_01_01()
        {
            When = new DateTime(2020, 11, 07);
            Details = new StringBuilder();

            Title = "<h2>Everything has changed</h2>";

            Details.Append("<p>We have moved house and are looking at building a fixed layout in the spear room, Expect more soon.</p>");
        }
    }
}