using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_05_16_Episode_17 : LayoutBase
    {
        public Layout_2021_05_16_Episode_17()
        {
            Active = false;
            When = new DateTime(2021, 05, 16);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-05-16 Episode 17\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0516\\";

            Title = "<h2>????????????????????</h2>";
            Details.Append("<p>Welcome back to Cattington, We have both been ill this week, so we haven't been able to do much as we would have liked.</p>");
            //Details.Append("<p>But we do have some progress on the hill.</p>");

            YouTubeLink = "???????????????";
        }
    }
}