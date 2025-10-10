using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021;

public class Layout_2021_09_19_Episode_26 : LayoutBase
{
    public Layout_2021_09_19_Episode_26()
    {
        Active = true;
        When = new DateTime(2021, 09, 19);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2021-09-19 26\";
        ExportImagePath = Constants.FullMyLayouts + "images\\0919\\";

        Title = "<h2>26: Layout, Backscene, and things</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");

        Details.Append("<p>We have added a back-scene to the Long Whiskers side of the railway</p>");
        Details.Append("<p>And also changed the layout again, so now Long Whiskers can be seen more and looks more like a station.</p>");
        Details.Append("<p>Updated the look of the bridge and bought a new house and wagons.</p>");
        YouTubeLink = "9lbbSN4bsaI";
    }
}