using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021;

public class Layout_2021_03_14_09_TownAndBridge : LayoutBase
{
    public Layout_2021_03_14_09_TownAndBridge()
    {
        When = new DateTime(2021, 03, 14);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2021-03-14 09 Town and Bridge\";
        ExportImagePath = Constants.FullMyLayouts + "images\\0314\\";

        Title = "<h2>09: Town and Bridge</h2>";
        Details.Append("<p>Welcome to cattington town, we have been updating the town with extra details, a village sign post, seating for the pub.</p>");
        Details.Append("<p>And also after a bit of re-design we are now going to have a second station along the main line.</p>");
        Details.Append("<p>We are going to call this new station Long Wishkers</p>");

        YouTubeLink = "y0yg6buOCYM";
    }
}