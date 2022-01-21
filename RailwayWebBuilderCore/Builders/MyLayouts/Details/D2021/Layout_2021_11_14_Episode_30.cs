using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_11_14_Episode_30 : LayoutBase
    {
        public Layout_2021_11_14_Episode_30()
        {
            Active = true;
            When = new DateTime(2021, 11, 14);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-11-14 30\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1114\\";

            Title = "<h2>30: New Factory</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have bought a new (second-hand) factory, and some more bargains.</p>");

            YouTubeLink = "8nszCJUQEIU";
        }
    }
}