using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2022
{
    public class Layout_2022_02_06_Episode_36 : LayoutBase
    {
        public Layout_2022_02_06_Episode_36()
        {
            Active = true;
            When = new DateTime(2022, 02, 06);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-02-06 36\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220206\\";

            Title = "<h2>36: Hut, Track and People</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>We show what it hidding under the hut,</p>");
            Details.Append("<p>Some track changes and more little people.</p>");

            YouTubeLink = "NeNTe8YAMHk";
        }
    }
}