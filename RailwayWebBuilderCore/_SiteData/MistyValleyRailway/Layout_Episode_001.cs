using RailwayWebBuilderCore._SiteData.MyLayouts.Details;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MistyValleyRailway;

public class Layout_Episode_001 : MistyLayoutBase, IBlogger
{
    public Layout_Episode_001()
    {
        Active = true;
        When = new DateTime(2026, 01, 01);
        EpisodeNumber = 001;

        InitDatedPaths();

        Title = "<h2>001: The Misty Valley Railway</h2>";
        Details.Append("<p>Here we announce the name of our new layout, and show you the progress so far.</p>");
        Details.Append("<p></p>");
        Details.Append("<p></p>");

        Details.Append("</br>");
        YouTubeLink = "??????????";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"The Misty Valley Railway {EpisodeNumber}",
            Date = When,
            Link = "MVRLayouts/index.html",
            Paragraph = "Named",
            KeyImage = $@"MVRLayouts\images\{When.ToString("yyyyMMdd")}\IMG_8488-thumb.JPG",
        };
    }
}