using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_01_31_Town : LayoutBase
    {
        public Layout_2021_01_31_Town()
        {
            When = new DateTime(2021, 01, 31);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-01-31 Town\";
            ExportImagePath = Constants.FullMyLayouts + "images\\011\\";

            Title = "<h2>03: Updating the Town</h2>";

            Details.Append("<p>We have started to work on the town</p>");

            YouTubeLink = "ozEH8lHAAH8";
        }
    }
}