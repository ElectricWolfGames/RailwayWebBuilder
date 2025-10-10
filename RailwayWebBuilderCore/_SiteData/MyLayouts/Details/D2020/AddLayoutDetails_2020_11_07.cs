using RailwayWebBuilderCore.Configuration;
using System;
using System.Text;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2020;

public class AddLayoutDetails_2020_11_07 : LayoutBase
{
    public AddLayoutDetails_2020_11_07()
    {
        When = new DateTime(2020, 11, 07);
        Details = new StringBuilder();

        RawImagePath = Constants.RawDataPath + @"MyLayout\2020-11-06 Running at the new House\";
        ExportImagePath = Constants.FullMyLayouts + "images\\006\\";
        YouTubeLink = "YpAjiulKqZ8";

        Title = "<h2>Home Running, in the new house</h2>";

        Details.Append("<p>Hello, This is the first full running day after we moved house. </p>");
        Details.Append("<p>Photos taken other 2 days, 05 and 06 November 2020</p>");
        Details.Append("<p>At one point we get 3 lines running, that lets use run 4 trains, thanks to DCC. Enjoy</p>");
    }
}