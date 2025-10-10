using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024;

public class SystonModelRailwaySocietyThorpe2024 : ModelEventPageDetails, IBlogger
{
    public SystonModelRailwaySocietyThorpe2024()
    {
        Name = "Syston Model Railway Society Thorpe 2024";
        Location = new RootsatThorpeFarmThorpe();
        EventDates = "11th, 12th May";
        Descrption = "Syston Model Railway Society";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-05-11 Syston Model Railway";
        TripDate = new DateTime(2024, 05, 11);

        YouTubeLink = "https://www.youtube.com/embed/iEEByqP7wW8";
        ImageFolder = "20240511-Thorpe";
        Title = "Syston Model Railway Society Thorpe 2024";
        ImagePreview = "IMG_6237-Pheonix-Junction-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BottomoftheBarrel));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bregstadt));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cunanavago));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Eyemouth));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.GlenmoreParva));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.JonesofTaunton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NorthRoad));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.PheonixJunction));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.StJohns));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TheHotTrack));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Victoria));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.UptonWhent));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Willevie));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Syston Model Railway Society", });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Thorpe Syston Model Railway Society",
            Date = new DateTime(2024, 05, 11),
            Paragraph = "We visited the Syston Model Railway Society on the 11th May 2024, lots of amazing models displays.",
            Link = $"{Constants.ModelEvents}/20240511-Thorpe/index.html",
            ModelEvent = this,
        };
    }
}