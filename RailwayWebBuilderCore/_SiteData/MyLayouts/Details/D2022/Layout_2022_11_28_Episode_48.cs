using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022;

public class Layout_2022_11_29_Episode_48 : LayoutBase
{
    public Layout_2022_11_29_Episode_48()
    {
        Active = true;
        When = new DateTime(2022, 11, 29);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2022-11-29 48\";
        ExportImagePath = Constants.FullMyLayouts + "images\\221129\\";

        Title = "<h2>48: Warley Bargains</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");

        Details.Append("<p>We visited Warley model railway show 2022 and picked up some bargains.</p>");
        Details.Append("<p>2 forklift trucks</p>");
        Details.Append("<p>Heljan 29051 British Rail Class 07 diesel-electric shunter, D2990 in BR green with wasp stripes</p>");
        Details.Append("<p>Hornby R6602 75 Ton Breakdown Crane in BR Red</p>");

        YouTubeLink = "cB078YzgFP8";
    }
}