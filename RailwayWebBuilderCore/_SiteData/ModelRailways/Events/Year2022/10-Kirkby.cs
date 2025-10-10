using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022;

public class Kirkby2022 : ModelEventPageDetails, IBlogger
{
    public Kirkby2022()
    {
        Name = "The Elizabethan Railway Society Exhibition";
        Location = new TheSummitCentreKirkby();
        EventDates = "8th October 2022";
        Descrption = "The Elizabethan Railway Society Exhibition at Kirkby-In-Ashfield.";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-10-08 Kirkby-In-Ashfield Model Railway Exhibition";
        TripDate = new DateTime(2022, 10, 08);
        YouTubeLink = "https://www.youtube.com/embed/CnT0kyIlDQY";
        ImageFolder = "20221008-Kirkby";
        Title = "The Elizabethan Railway Society Exhibition 2022";
        ImagePreview = "PA081440-2022-10-08-Oscarton-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ambleside));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.StMichaelsVale));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brunshafen));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BrittaniaMills));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SheffieldVictoria));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Burgedorf));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Elmfield));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Oscarton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brassingdale));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NormanColliery));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Kirkby-In-Ashfield",
            "The Elizabethan Railway Society Exhibition",
            "Kirkby-In-Ashfield Model Railway" });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "The Elizabethan Railway Society Exhibition",
            Date = new DateTime(2022, 10, 08),
            Paragraph = "Visited The Elizabethan Railway Society Exhibition event on the 08th October, Fantastic People, Amazing layouts",
            Link = $"{Constants.ModelEvents}/20221008-Kirkby/index.html",
            ModelEvent = this,
        };
    }
}