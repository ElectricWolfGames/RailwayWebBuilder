using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022;

public class Layout_2022_06_12_Episode_45 : LayoutBase
{
    public Layout_2022_06_12_Episode_45()
    {
        Active = true;
        When = new DateTime(2022, 06, 12);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2022-06-12 45\";
        ExportImagePath = Constants.FullMyLayouts + "images\\220612\\";

        Title = "<h2>45: Track and Track!</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");

        Details.Append("<p>We have been gluing some track down</p>");
        Details.Append("<p>And we open up the Cadbury Castle</p>");

        YouTubeLink = "9A8jkbwoQ2k";
    }
}