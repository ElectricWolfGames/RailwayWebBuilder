using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MistyValleyRailway;

public class Layout_Episode_002 : MistyLayoutBase, IBlogger
{
    public Layout_Episode_002()
    {
        Active = true;
        When = new DateTime(2026, 01, 04);
        EpisodeNumber = 002;

        InitDatedPaths();

        Title = "<h2>002: Light and Track, and new Rolling Stock | Model Railway Episode 2</h2>";
        Details.Append("<p>Here Misty Valley railway</p>");
        Details.Append("<p></p>");
        Details.Append("<p>I show off the new lighting we have, </p>");
        Details.Append("<p></p>");
        Details.Append("<p>Share we you the new rolling stock and loco we have at the railway</p>");
        Details.Append("<p>Show more of the track structure</p>");

        Details.Append("</br>");
        YouTubeLink = "8hXrnG-bBpY";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"The Misty Valley Railway {EpisodeNumber}",
            Date = When,
            Link = $"{Constants.MVRLayouts}/index.html",
            Paragraph = "Lights, Track and Rolling stock",
            KeyImage = $@"{Constants.MVRLayouts}\images\{When.ToString("yyyyMMdd")}\IMG_8835.JPG",
        };
    }
}