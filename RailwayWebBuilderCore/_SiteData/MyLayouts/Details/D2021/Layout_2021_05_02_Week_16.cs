using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_05_02_Week_16 : LayoutBase
    {
        public Layout_2021_05_02_Week_16()
        {
            Active = true;
            When = new DateTime(2021, 05, 02);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-05-02 Station Yard\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0502\\";

            Title = "<h2>16: Station Yard and Wedding guests</h2>";
            Details.Append("<p>Welcome back to Cattington, We have updated the tunnel entrance, work around the station yard</p>");
            Details.Append("<p>And we have added Wedding guests to the church yard.</p>");

            YouTubeLink = "uVGsIlgSjeg";
        }
    }
}