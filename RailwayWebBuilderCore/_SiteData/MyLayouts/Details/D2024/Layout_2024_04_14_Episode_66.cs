using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2024;

public class Layout_2024_04_14_Episode_66 : LayoutBase, IBlogger
{
    public Layout_2024_04_14_Episode_66()
    {
        Active = true;
        When = new DateTime(2024, 04, 14);
        EpisodeNumber = 66;

        InitDatedPaths();

        Title = "<h2>66: 2 Guest locos</h2>";
        Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
        Details.Append("</br>");
        Details.Append("<p>The 2 guest loco to show you. </p>");
        Details.Append("<p>31-138 Class D11/2 62682 Haystoun of Bucklaw</p>");
        Details.Append("<p>31-004A Robinson Class 04 63601</p>");
        Details.Append("<p>And we have some small updates around the layout</p>");

        Details.Append("</br>");
        Details.Append("<p>Thank you for watching, Take care</p>");
        YouTubeLink = "5hnthG9XRbE";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"Cattington Update {EpisodeNumber}",
            Date = When,
            Link = "MyLayouts/index.html",
            Paragraph = "2 Guest locos, Small layout updates",
            KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_5904-thumb.JPG",
        };
    }
}