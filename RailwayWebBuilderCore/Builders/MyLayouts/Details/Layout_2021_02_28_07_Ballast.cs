using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class Layout_2021_02_28_07_Ballast : LayoutBase
    {
        public Layout_2021_02_28_07_Ballast()
        {
            When = new DateTime(2021, 02, 28);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-02-28 07 Ballast\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0228\\";

            Title = "<h2>Ballast!</h2>";

            Details.Append("<p>We have spent a lot of time Ballasting the track on one side of the layout, and a little bit more wiring.</p>");

            YouTubeLink = "zAH4VKJ3ims";
        }
    }
}