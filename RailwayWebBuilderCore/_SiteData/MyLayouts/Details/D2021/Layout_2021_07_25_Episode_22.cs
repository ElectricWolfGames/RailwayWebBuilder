using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021
{
    public class Layout_2021_07_25_Episode_22 : LayoutBase
    {
        public Layout_2021_07_25_Episode_22()
        {
            Active = true;
            When = new DateTime(2021, 07, 25);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-07-25 22\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0725\\";

            Title = "<h2>22: House and Track</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have finished the house and changed the shunting yard (again)</p>");

            YouTubeLink = "bhzS0uJ62WM";
        }
    }
}