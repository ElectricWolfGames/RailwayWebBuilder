using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;
using RailwayWebBuilderCore.Builders.MyLayouts.Details;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_07_11_Episode_21 : LayoutBase
    {
        public Layout_2021_07_11_Episode_21()
        {
            Active = true;
            When = new DateTime(2021, 07, 11);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-07-11 21\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0711\\";

            Title = "<h2>21: Scenery update and Tunnel entrance</h2>";
            Details.Append("<p>Welcome back to Cattington,</p>");

            Details.Append("<p>We have been working on the corner, Where we have a retaining wall and a raised section to place building and part of a road.</p>");
            Details.Append("<p>And started on another terrace house for cattington village</p>");

            YouTubeLink = "W7Oy1JdGa6o";
        }
    }
}
