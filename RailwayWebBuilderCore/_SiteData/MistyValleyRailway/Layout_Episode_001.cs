using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MistyValleyRailway;

public class Layout_Episode_001 : MistyLayoutBase, IBlogger
{
    public Layout_Episode_001()
    {
        Active = true;
        When = new DateTime(2025, 12, 20);
        EpisodeNumber = 001;

        InitDatedPaths();

        Title = "<h2>001: Name of the Layout | Model Railway Episode 1</h2>";
        Details.Append("<p>Here we announce the name of our new layout, and show you the progress so far.</p>");
        Details.Append("<p></p>");
        Details.Append("<p>This new layout is going to be called 'Misty Vallety Railway'</p>");
        Details.Append("<p></p>");
        Details.Append("<p>I've started to replace the tempary wooden supports with cut wood.</p>");

        Details.Append("</br>");
        YouTubeLink = "https://youtu.be/NjXjlw-5p0s";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"The Misty Valley Railway {EpisodeNumber}",
            Date = When,
            Link = $"{Constants.MVRLayouts}/index.html",
            Paragraph = "Named",
            KeyImage = $@"MVRLayouts\images\{When.ToString("yyyyMMdd")}\IMG_8488-thumb.JPG",
        };
    }
}