using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;
using RailwayWebBuilderCore.Builders.MyLayouts.Details;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details.D2021
{
    public class Layout_2021_06_13_Episode_19 : LayoutBase
    {
        public Layout_2021_06_13_Episode_19()
        {
            Active = true;
            When = new DateTime(2021, 06, 13);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2021-06-13 19\";
            ExportImagePath = Constants.FullMyLayouts + "images\\0613\\";

            Title = "<h2>19: More Wagons and a Garage</h2>";
            Details.Append("<p>Welcome back to Cattington, We have just added a Garage to the layout</p>");

            Details.Append("<p>And updated the hill, and picked up some more bargains, from </p>");

            Details.Append("<strong>Micks Toys</strong>");
            Details.Append("<p>Windsor St, Melton Mowbray LE13 1BU</p>");
            Details.Append("<p>And Loughborough friday Market.<p>");

            YouTubeLink = "RdVnOCkXW20";
        }
    }
}
