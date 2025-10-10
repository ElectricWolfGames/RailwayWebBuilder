using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021;

public class Layout_2021_10_31_Episode_29 : LayoutBase
{
    public Layout_2021_10_31_Episode_29()
    {
        Active = true;
        When = new DateTime(2021, 10, 31);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2021-10-31 29\";
        ExportImagePath = Constants.FullMyLayouts + "images\\1031\\";

        Title = "<h2>29: More bargains</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");

        Details.Append("<p>Picked up a few bargains from the Emporium at GCR Loughborough Station.</p>");

        YouTubeLink = "THsunzYamdo";
    }
}