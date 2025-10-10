using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2019;

public class Linclon2019 : ModelEventPageDetails
{
    public Linclon2019()
    {
        Name = "Newark - Lincoln Model Rail Club Post Modernisation Exhibition";
        Location = new NewarkShowground();
        EventDates = "19th and 20th October 2019";
        Descrption = "Lincoln Model Rail Club Post Modernisation Exhibition";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2019-10-19 Newark Model LincolnModelRailClub";
        TripDate = new DateTime(2019, 10, 19);
        YouTubeLink = "https://www.youtube.com/embed/sfhv8iYXiYU";
        ImageFolder = "20191019-Lincoln";
        Title = "Lincoln Model Rail Club 2019";
        ImagePreview = "PA196601-Newark-Model-Lincoln-model-rail-club-Crimson-road-thumb.JPG";

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] { "Linclon", "Lincoln Model Rail Club", "Newark Showground", "Post Modernisation Exhibition" });

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CrimsonRoad));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cumanavago));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.DovingtonCamp));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.EightDollarCanyon));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.EuxtonJunction));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Gillingbourne));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HollandBeck));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.IllieTown));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KStreetYard));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LeaGreenYard));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LochTat));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LowMoor));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LynchwoodSidings));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NortonFolgate));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.OilDrumLane));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.PennaLane));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SutherlandStreet));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TitheridgeJunction));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.WeaverHill));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.WestStreetStation));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.ZlataVychod));
    }
}