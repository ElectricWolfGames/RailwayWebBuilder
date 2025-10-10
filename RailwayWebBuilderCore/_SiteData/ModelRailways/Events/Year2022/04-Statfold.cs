using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022;

public class Statfold2022 : ModelEventPageDetails, IBlogger
{
    public Statfold2022()
    {
        Name = "Statfold Model Railway Event";
        Location = new StatfoldBarnRailway();
        EventDates = "9th April 2022";
        Descrption = "Statfold Model Railway Event";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-04-09 Statfold Model Railway Event";
        TripDate = new DateTime(2022, 04, 07);
        YouTubeLink = "https://www.youtube.com/embed/8giNIWlU7Wo";
        ImageFolder = "20220409-Statfold";
        Title = "Statfold Model Railway Event";
        ImagePreview = "P4097587-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.AppletonDene));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Arley));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BurlishRoad));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CampbellQuarry));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CarolineConcrete));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Coleford));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cregwir));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Duxbury));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.FairlieSyniadDa));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Grenstad));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.GrestyBridge));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Hackworth_JutlandSt));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Halland));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HambledenValley));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HeanorSouth));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KarolinaFalls, "Karolina Falls"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KnowlesHillColliery));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MedwayQuay));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MerstoneandVentnor));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MiddleElmton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.QuornMagna));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.RidgeLane));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.RushGreenColliery));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Scole));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SixpennyHandley));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthWigston, "South Wigston"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthgatePark));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttonBankTMD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TanyBwlch, "A6 - TanyBwlch"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Tramline));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TryffanDdu, "R12 - Tryffan Ddu"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ulvyard));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.UpsonDownTramwayMuseum));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Statfold Model Railway Event",
           });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Statfold Model Railway Event",
            Date = new DateTime(2022, 04, 09),
            Paragraph = "Visited the The Statfold Model Railway Event on the 9th, 10th April, lots of amazing models displays.",
            Link = $"{Constants.ModelEvents}/20220409-Statfold/index.html",
            ModelEvent = this,
        };
    }
}