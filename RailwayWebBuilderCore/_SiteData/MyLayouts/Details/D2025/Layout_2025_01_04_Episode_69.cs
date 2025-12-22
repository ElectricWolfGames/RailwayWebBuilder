using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2025;

public class Layout_2025_01_04_Episode_69 : LayoutBase, IBlogger
{
    public Layout_2025_01_04_Episode_69()
    {
        Active = true;
        When = new DateTime(2025, 01, 04);
        EpisodeNumber = 69;

        InitDatedPaths();

        Title = "<h2>69: Hill, Goods Sheds and Wagons</h2>";
        Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
        Details.Append("</br>");
        Details.Append("<p>We have updated the hill with the castle</p>");
        Details.Append("<p>Build two Good sheds for the sidings</p>");
        Details.Append("<p>Debbie weathered some tanker wagons</p>");
        Details.Append("<p>I show how the wagon storage is doing</p>");
        Details.Append("<p>And show some nice new wagons</p>");

        Details.Append("</br>");
        Details.Append("<p>Thank you for watching, Take care</p>");
        YouTubeLink = "4fLDQkoq4m4";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"Cattington Update {EpisodeNumber}",
            Date = When,
            Link = "MyLayouts/index.html",
            Paragraph = "Hill, Goods Sheds and Wagons",
            KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_7676-2025-01-04-Cattington-thumb.JPG",
        };
    }
}