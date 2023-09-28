using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_01_17_Boards : LayoutBase
    {
        public Layout_2021_01_17_Boards()
        {
            When = new DateTime(2021, 01, 17);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-01-17 First Fixedlayout\";
            ExportImagePath = Constants.FullMyLayouts + "images\\009\\";

            Title = "<h2>01: Started our fixed layout</h2>";

            Details.Append("<p>We have our base boards and we have just finished building them in our spare bedroom.</p>");
            Details.Append("<p>The boards are from <a href='https://www.whiterosemodelworks.co.uk/' target=blank'>White Rose Model Works</a>, Very good quality and price.</p>");

            YouTubeLink = "nZ64DxtbbNQ";
        }
    }
}