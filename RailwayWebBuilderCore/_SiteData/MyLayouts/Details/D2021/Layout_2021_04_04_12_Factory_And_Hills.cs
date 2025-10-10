using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2021;

public class Layout_2021_04_04_12_Factory_And_Hills : LayoutBase
{
    public Layout_2021_04_04_12_Factory_And_Hills()
    {
        When = new DateTime(2021, 04, 04);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2021-04-04 12 Factory and Hill\";
        ExportImagePath = Constants.FullMyLayouts + "images\\0404\\";

        Title = "<h2>12: Factory and Hill</h2>";
        Details.Append("<p>Welcome back to Cattington, We have added more details to the town.</p>");
        Details.Append("<p>We finally started to make the hill and tunnel look like a hill and tunnel!</p>");
        Details.Append("<p>And added the framework for the factory.</p>");

        Details.Append("<p>And if you would like to smile, Watch some of Tommy the Tank jokes on ");
        Details.Append("<a href='https://www.youtube.com/channel/UCEPVOMbHd93lzDnT4s5GXsg'>Paul's Channel</a> </p>");

        // _pageBuilder.Append("<li class='breadcrumb-item'><a href='../../index.html'>Home</a></li>");

        YouTubeLink = "3nMAXJ4qKo4";
    }
}