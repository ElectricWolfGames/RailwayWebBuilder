using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MistyValleyRailway;

public class Layout_Episode_003 : MistyLayoutBase, IBlogger
{
    public Layout_Episode_003()
    {
        Active = true;
        When = new DateTime(2026, 03, 14);
        EpisodeNumber = 003;

        InitDatedPaths();

        Title = "<h2>003: Embankment and Bridges | Model Railway Episode 3</h2>";
        Details.Append("<p>Here Misty Valley railway</p>");
        Details.Append("<p></p>");
        Details.Append("<p>we have a new bridge to show and some work on the Embankment</p>");

        Details.Append("</br>");
        YouTubeLink = "tnANGcHqig8";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"The Misty Valley Railway {EpisodeNumber}",
            Date = When,
            Link = $"{Constants.MVRLayouts}/index.html",
            Paragraph = "Embankment and Bridges",
            KeyImage = $@"{Constants.MVRLayouts}\images\{When.ToString("yyyyMMdd")}\IMG_8901.JPG",
        };
    }
}