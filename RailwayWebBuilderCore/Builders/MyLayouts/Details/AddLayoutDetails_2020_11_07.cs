using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2020_11_07 : ILayoutPagesDetails
    {
        public string RawImagePath { get; }
        public string ExportImagePath { get; }
        public string YouTubeLink { get; }
        public string Title { get; }
        public StringBuilder Details { get; }
        public DateTime When { get; }

        public AddLayoutDetails_2020_11_07()
        {
            When = new DateTime(2020, 11, 07);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2020-11-06 Running at the new House\";
            ExportImagePath = Constants.FullMyLayouts + "images\\006\\";
            YouTubeLink = "YpAjiulKqZ8";

            Title = "<h2>Home Running, in the new house</h2>";

            Details.Append("<p>Hello, This is the first full running day after we moved house. </p>");
            Details.Append("<p>Photos taken other 2 days, 05 and 06 November 2020</p>");
            Details.Append("<p>At one point we get 3 lines running, that lets use run 4 trains, thanks to DCC. Enjoy</p>");
        }
    }
}