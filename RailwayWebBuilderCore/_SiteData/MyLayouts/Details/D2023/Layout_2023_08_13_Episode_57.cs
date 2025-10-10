using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023;

public class Layout_2023_08_13_Episode_57 : LayoutBase, IBlogger
{
    public Layout_2023_08_13_Episode_57()
    {
        Active = true;
        When = new DateTime(2023, 08, 13);
        EpisodeNumber = 57;

        InitDatedPaths();

        Title = "<h2>57: Westerns and more wagons</h2>";
        Details.Append("<p>Welcome back to Cattington,</p>");

        Details.Append("<p>We have done some more trace work around long whiskers</p>");
        Details.Append("<p>This week we have 3 guest locos, Class 52 Westerns</p>");
        Details.Append("<ul>");
        Details.Append("<li>Dapol Class 52 Western champion Golden Ochre T Panel D1015</li>");
        Details.Append("<li>Dapol Class 52 Western Dragoon BR Maroon SYP D1034</li>");
        Details.Append("<li>Heljan 5201 Class 52 Western D1037 Empress</li>");
        Details.Append("</ul>");

        Details.Append("<p>And we also show roll stock we recently picked up</p>");

        Details.Append("</br>");

        YouTubeLink = "zKQkH6KLHY4";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"Cattington Update {EpisodeNumber}",
            Date = When,
            Link = "MyLayouts/index.html",
            Paragraph = "Westerns and more wagons",
            KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4254-2023-08-13-Cattington-thumb.JPG",
        };
    }
}