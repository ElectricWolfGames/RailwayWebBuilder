using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public class AddLayoutDetails_2020_05_11 : LayoutBase
    {
        public AddLayoutDetails_2020_05_11()
        {
            When = new DateTime(2020, 05, 11);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\2020-05-11 Hills are green\";
            ExportImagePath = Constants.FullMyLayouts + "images\\005\\";

            Title = "<h2>I see grass! (Shelf display)</h2>";

            Details.Append("<p>Final added some grass, shrubs and fences to my Shelf display</p>");
        }
    }
}