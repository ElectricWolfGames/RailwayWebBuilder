using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2023;

public class IvanhoeModelRailway2023 : ModelEventPageDetails, IBlogger
{
    public IvanhoeModelRailway2023()
    {
        Name = "Ivanhoe Model Railway Society";
        Location = new TheMountsorrelMemorialCentre();
        EventDates = "11th / 12th March";
        Descrption = "Ivanhoe Model Railway Society at Mountsorrel.";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-03-11 Ivanhoe Model Railway Society";
        TripDate = new DateTime(2023, 03, 11);
        YouTubeLink = "https://www.youtube.com/embed/qkNti83ufYA";
        ImageFolder = "20230311-Mountsorrel";
        Title = "Ivanhoe Model Railway Society 2023";
        ImagePreview = "IMG_3172-2023-03-11-Eu-Depot.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bankwood));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BearCreek));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Boghampton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Burdock));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CarriageandWagon));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.EuDepot));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.GardenHalt));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HeanorSouth));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Hopeless));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KnotLittlefield));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LionelVintageCollection));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LymebrookYard));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MillfieldYard));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BuggleskellyModels));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Silverton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TanYFron));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ullapool));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.WhealKist));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LondonRoad));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Ivanhoe Model Railway Society"
            });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Ivanhoe Model Railway Society",
            Date = new DateTime(2023, 03, 11),
            Paragraph = "Visited The Ivanhoe Model Railway Society event on the 11th and 12th March, Fantastic People, Amazing layouts",
            Link = $"{Constants.ModelEvents}/20230311-Mountsorrel/index.html",
            ModelEvent = this,
        };
    }
}