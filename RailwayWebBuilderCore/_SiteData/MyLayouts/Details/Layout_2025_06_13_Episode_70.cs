using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details;

public class Layout_2025_06_13_Episode_70 : LayoutBase, IBlogger
{
    public Layout_2025_06_13_Episode_70()
    {
        Active = true;
        When = new DateTime(2025, 06, 13);
        EpisodeNumber = 70;

        InitDatedPaths();

        Title = "<h2>70: One final look around Cattington</h2>";
        Details.Append("<p>A Final Look at 'Cattington' – Our Model Railway Farewell | Karl and Debbie Trains</p>");
        Details.Append("</br>");
        Details.Append("<p>Join us for one last tour of Cattington, our beloved model railway layout, before we begin the process of taking it apart. In this video.</p>");
        Details.Append("<p>Whether you’ve followed our journey from the start or are just discovering our channel, we’d love for you to be part of this farewell. Thank you for all the support – and don’t worry, this isn’t the end… it’s the beginning of a new railway adventure!</p>");
        Details.Append("<p></p>");
        Details.Append("<p></p>");

        Details.Append("</br>");
        Details.Append("<p>Please mind the gap...</p>");
        YouTubeLink = "7J6mJ19kXWk";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"Cattington Update {EpisodeNumber}",
            Date = When,
            Link = "MyLayouts/index.html",
            Paragraph = " One final look around Cattington",
            KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_8488-thumb.JPG",
        };
    }
}