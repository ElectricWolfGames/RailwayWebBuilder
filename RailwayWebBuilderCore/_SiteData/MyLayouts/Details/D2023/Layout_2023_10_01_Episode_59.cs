using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.MyLayouts.Details.D2023;

public class Layout_2023_10_01_Episode_59 : LayoutBase, IBlogger
{
    public Layout_2023_10_01_Episode_59()
    {
        Active = true;
        When = new DateTime(2023, 10, 01);
        EpisodeNumber = 59;

        InitDatedPaths();

        Title = "<h2>59: New Tool, New Wagons and Class 28s</h2>";
        Details.Append("<p>Hello and welcome back to Karl and Debbie trains, And we have another Cattington model railway layout update for you.</p>");
        Details.Append("</br>");
        Details.Append("<p>This time we have a new tool to show you - a track tester. Some new ocean wagons and some guest loco's</p>");
        Details.Append("<p>The Track tester is a 'Train tech Multi gauge track tester' we picked up for £10. And the guest locos are all 28's</p>");

        Details.Append("</br>");
        Details.Append("<ul>");
        Details.Append("<li>2233 Hornby Dublo Co-Bo Diesel Electric Class 28 D5702</li>");
        Details.Append("<li>28031 Heljan Class 28 D5717 Br green with small yellow ends</li>");
        Details.Append("<li>Hattons Heljan Metrovic CL28 Co-Bo D5709 Br Green Weathered</li>");
        Details.Append("</ul>");
        Details.Append("</br>");
        Details.Append("<p>In the Running session, we start with Class 07 D2988 and Class 08 08648 building up a freight train for Class 28.</p>");
        Details.Append("</br>");
        Details.Append("</br>");
        Details.Append("<p>Thank you for watching, Take care</p>");
        YouTubeLink = "GYRzipZfIqI";
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = $"Cattington Update {EpisodeNumber}",
            Date = When,
            Link = "MyLayouts/index.html",
            Paragraph = "New Tool, New Wagons and Class 28s",
            KeyImage = $@"MyLayouts\images\{When.ToString("yyyyMMdd")}\IMG_4765-Cattington-thumb.JPG",
        };
    }
}