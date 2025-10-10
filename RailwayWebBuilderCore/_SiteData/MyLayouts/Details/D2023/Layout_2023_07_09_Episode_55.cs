using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023;

public class Layout_2023_07_09_Episode_55 : LayoutBase
{
    public Layout_2023_07_09_Episode_55()
    {
        Active = true;
        When = new DateTime(2023, 07, 09);
        EpisodeNumber = 55;

        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2023-07-09 55\";
        ExportImagePath = Constants.FullMyLayouts + "images\\230709\\";

        Title = "<h2>55: Warship!</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");

        Details.Append("<p>More work on the track near long whiskers</p>");
        Details.Append("<p>And 2 Warships make a guest appearance</p>");

        Details.Append("</br>");

        YouTubeLink = "SvpLNzBvhx8";
    }
}