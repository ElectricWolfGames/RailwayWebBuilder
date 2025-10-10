using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021;

public class Layout_2021_03_28_11_Market_Day : LayoutBase
{
    public Layout_2021_03_28_11_Market_Day()
    {
        When = new DateTime(2021, 03, 28);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2021-03-28 11 Market Day\";
        ExportImagePath = Constants.FullMyLayouts + "images\\0328\\";

        Title = "<h2>11: It's Market Day at Cattington</h2>";
        Details.Append("<p>Welcome back to Cattington, More people have arrived!</p>");
        Details.Append("<p>So we have created a small market at the vicar's house</p>");

        YouTubeLink = "xAeaQfG3Ke4";
    }
}