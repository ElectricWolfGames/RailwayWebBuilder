using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2024;

public class Layout_2024_03_31_Episode_65 : LayoutBase, IBlogger
{
    public Layout_2024_03_31_Episode_65()
    {
        Active = true;
        When = new DateTime(2024, 03, 31);
        EpisodeNumber = 65;

        InitDatedPaths();

        Title = "<h2>65: New Loco</h2>";
        Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
        Details.Append("</br>");
        Details.Append("<p>We have a new Loco, Class 14 </p>");
        Details.Append("<p>D9545 - 1413 BR Green Class 14 </p>");
        Details.Append("<p>And we have some small updates around the layout</p>");

        Details.Append("</br>");
        Details.Append("<p>Thank you for watching, Take care</p>");
        YouTubeLink = "8sI6o6__t9g";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"Cattington Update {EpisodeNumber}",
            Date = When,
            Link = "MyLayouts/index.html",
            Paragraph = "New Loco, Small layout updates",
            KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_5682-Cattington-thumb.JPG",
        };
    }
}