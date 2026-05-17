using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MistyValleyRailway;

public class Layout_Episode_004 : MistyLayoutBase, IBlogger
{
    public Layout_Episode_004()
    {
        Active = true;
        When = new DateTime(2026, 05, 22);
        EpisodeNumber = 004;

        InitDatedPaths();

        Title = "<h2>004: Embankment and Road | Model Railway Episode 4</h2>";
        Details.Append("<p>Here Misty Valley railway</p>");
        Details.Append("<p></p>");
        Details.Append("<p>We have updated the corner of the railway with some scenic </p>");
        Details.Append("<p>It's starting to make the layout come to life!</p>");

        Details.Append("</br>");
        YouTubeLink = "";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"The Misty Valley Railway {EpisodeNumber}",
            Date = When,
            Link = $"{Constants.MVRLayouts}/index.html",
            Paragraph = "Embankment and Road",
            KeyImage = $@"{Constants.MVRLayouts}\images\{When.ToString("yyyyMMdd")}\IMG_8994-thumb.JPG",
        };
    }
}