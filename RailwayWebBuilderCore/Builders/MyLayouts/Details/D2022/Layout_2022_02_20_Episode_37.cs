using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2022
{
    public class Layout_2022_02_20_Episode_37 : LayoutBase
    {
        public Layout_2022_02_20_Episode_37()
        {
            Active = true;
            When = new DateTime(2022, 02, 20);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2022-02-20 37\";
            ExportImagePath = Constants.FullMyLayouts + "images\\220220\\";

            Title = "<h2>37: Embankment and Pavements</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");
            Details.Append("<p>We are planning the next part of the hill project and working on the pavements</p>");
            Details.Append("<p>And we have been updating the layout again.</p>");

            YouTubeLink = "l-5hfa1Drao";
        }
    }

}