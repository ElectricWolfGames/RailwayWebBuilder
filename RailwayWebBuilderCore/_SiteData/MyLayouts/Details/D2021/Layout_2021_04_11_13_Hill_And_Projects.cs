using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_04_11_13_Hill_And_Projects : LayoutBase
    {
        public Layout_2021_04_11_13_Hill_And_Projects()
        {
            When = new DateTime(2021, 04, 11);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-04-11 13 Hill and Projects\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0411\\";

            Title = "<h2>13: Hill and Projects</h2>";
            Details.Append("<p>Welcome back to Cattington, We have both been ill this week, so we haven't been able to do much as we would have liked.</p>");
            Details.Append("<p>But we do have some progress on the hill.</p>");

            YouTubeLink = "2hNvMrjz8EU";
        }
    }
}