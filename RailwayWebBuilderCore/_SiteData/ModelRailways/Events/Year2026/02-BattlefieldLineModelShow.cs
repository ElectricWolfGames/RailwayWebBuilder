using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Years2026;

public class BattlefieldLineMoodleShow2026 : ModelEventPageDetails, IBlogger
{
    public BattlefieldLineMoodleShow2026()
    {
        Name = "Battlefield Line Model Show 2026";
        Location = new MarketBosworthStation();
        EventDates = "Sat 8th Aug 2026";
        Descrption = "Battlefield Line Model Show";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2026-08-08 Battlefield Line Model Show";
        TripDate = new DateTime(2026, 08, 08);
        YouTubeLink = "https://www.youtube.com/embed/?????????";
        ImageFolder = "20260808-Battlefield";
        Title = "Battlefield Line Model Show 2026";
        ImagePreview = "IMG_9052-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.AvynALlyin));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BellswoodEnd));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BluishMoor));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BywayMPD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CardingRoad));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.DaisyLaneTMD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.PenleeHarbour));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Rawdon));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SharnbrookSummit));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KelvinGroveToThompsonStreet));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TwoLocks));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Battlefield Line Model Show",
            "Battlefield Line Model Show 2026",
            "Battlefield Line Railway",
            "Battlefield Line",
            "Market Bosworth Station",
            "Market Bosworth",
            "Shackerstone",
            "Hinckley and Bosworth",
            "Leicestershire",
            "Model railway exhibition",
            "Model railway show",
            "Heritage railway",
            "OO gauge",
            "OO9 gauge",
            "N gauge",
            "O gauge",
            "Gauge 1",
            "3mm scale",
           });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Battlefield Line Model Show 2026",
            Date = new DateTime(2026, 08, 08),
            Paragraph = "Battlefield Line Model Show 2026",
            Link = $"{Constants.ModelEvents}/20260808-Battlefield/index.html",
            ModelEvent = this,
        };
    }
}