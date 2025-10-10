using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2022;

public class Layout_2022_03_06_Episode_38 : LayoutBase
{
    public Layout_2022_03_06_Episode_38()
    {
        Active = true;
        When = new DateTime(2022, 03, 06);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2022-03-06 38\";
        ExportImagePath = Constants.FullMyLayouts + "images\\220306\\";

        Title = "<h2>38: Bargains and new Loco</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");
        Details.Append("<p>After a trip to Nottingham Model Railway Society, we picked up some more bargains.</p>");
        Details.Append("<p>New loco, More track, and some more people.</p>");

        YouTubeLink = "51043kOuZQM";
    }
}