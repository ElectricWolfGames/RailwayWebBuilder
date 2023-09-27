using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2020
{
    public class AddLayoutDetails_2020_04_16 : LayoutBase
    {
        public AddLayoutDetails_2020_04_16()
        {
            When = new DateTime(2020, 04, 16);
            Details = new StringBuilder();

            RawImagePath = Constants.RawDataPath + @"MyLayout\003-HillsAndTrack\";
            ExportImagePath = Constants.FullMyLayouts + "images\\003\\";

            Title = "<h2>It's been a while (Shelf display)</h2>";

            Details.Append("<p>Ok, I've final remembered to take some photo and upload them.</p>");
            Details.Append("<p>Here are some image of my Shelf display, it's just a static scene to have a nice place to put locos on and leave them on display.</p>");
            Details.Append("<p>next will be the bridge and track along the top.</p>");
        }
    }
}