using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021;

public class Layout_2021_05_30_Episode_18 : LayoutBase
{
    public Layout_2021_05_30_Episode_18()
    {
        Active = true;
        When = new DateTime(2021, 05, 30);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2021-05-30 18\";
        ExportImagePath = Constants.FullMyLayouts + "images\\0530\\";

        Title = "<h2>18: Castle and Layout</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");
        Details.Append("<p>We have updated castle tyson, it's now looking very impressive!</p>");
        Details.Append("<p>and updated the layout with two express points to give us smoother running</p>");

        YouTubeLink = "tU-96vIr6tY";
    }
}