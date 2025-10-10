using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2021;

public class Hinckley2021 : ModelEventPageDetails, IBlogger
{
    public Hinckley2021()
    {
        Name = "Hinckley Model Railway Show";
        Location = new TheForrayanCentreHinckley();
        EventDates = "30th October 2021";
        Descrption = "Hinckley Model Railway Show at Hinckley, Leicestershire .";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2021-10-30 Hinckley Model Railway Show";
        TripDate = new DateTime(2021, 10, 30);
        YouTubeLink = "https://www.youtube.com/embed/GYXOvy2pk6w";
        ImageFolder = "20211030-Hinckley";
        Title = "Hinckley Model Railway Show 2021";
        ImagePreview = "PA305806-2021-10-30-Hinckley-model-show-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Buxworth));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TheElectricTram));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.RobinsonHeath));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CanalParkandStation));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BadgersHollow));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MagnaPark));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.StRuth));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "The Forrayan Centre",
            "Hinckley Model Railway Show",
            "Railway Show at Hinckley" });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Hinckley Model Railway Show 2021",
            Date = new DateTime(2021, 10, 30),
            Paragraph = "Visited the The Hinckley Model Railway Show on the 30th October, lots of amazing models displays.",
            Link = $"{Constants.ModelEvents}/20211030-Hinckley/index.html",
            ModelEvent = this,
        };
    }
}