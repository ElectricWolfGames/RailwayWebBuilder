using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022;

public class Clifton2022 : ModelEventPageDetails, IBlogger
{
    public Clifton2022()
    {
        Name = "Nottingham Model Railway Society";
        Location = new HighbankCommunityCentreNottingham();
        EventDates = "26th February 2022";
        Descrption = "Nottingham Model Railway Society's Spring Show at Clifton, Nottingham";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-02-26 Clifton Model Railway Show";
        TripDate = new DateTime(2022, 02, 26);
        YouTubeLink = "https://www.youtube.com/embed/m3G7lo75vaE";
        ImageFolder = "20220226-Clifton";
        Title = "Nottingham Model Railway Society";
        ImagePreview = "P2266927-2022-02-26-Netherwood-sidings-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TasteOfAlber));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NorthHaston));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NetherwoodSidings));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HazelbyBallastLoader));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.WelbyLane, "Welby Lane RTC"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Junesdale));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BrittaniaMills));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HollingtonQuarry));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.EastMidlandsFremoGroup));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Clifton, Nottingham",
            "Nottingham Model Railway Society",
            "Clifton Model Railway Exhibition" });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Nottingham Model Railway Society Exhibition",
            Date = new DateTime(2022, 02, 26),
            Paragraph = "Visited the The Nottingham Model Railway Society Exhibition event on the 26th, 27th February, lots of amazing models displays.",
            Link = $"{Constants.ModelEvents}/20220226-Clifton/index.html",
            ModelEvent = this,
        };
    }
}