using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_11_28_Episode_31 : LayoutBase
    {
        public Layout_2021_11_28_Episode_31()
        {
            Active = true;
            When = new DateTime(2021, 11, 28);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-11-28 31\";
            ExportImagePath = Constants.FullMyLayouts + "images\\1128\\";

            Title = "<h2>31: Locos at Cattington</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>Lets take a look at all the loco we have.</p>");

            YouTubeLink = "TlRAAubVj2o";
        }
    }
}