using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2023;

public class StatfoldBarn2023 : ModelEventPageDetails, IBlogger
{
    public StatfoldBarn2023()
    {
        Name = "Statfold Model Railway Event";
        Location = new StatfoldBarnRailway();
        EventDates = "1th April 2023";
        Descrption = "Statfold Model Railway Event";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-04-01 Statfold Model Railway Event";
        TripDate = new DateTime(2023, 04, 01);
        YouTubeLink = "https://www.youtube.com/embed/OU8kW0bMvXg";
        ImageFolder = "20230401-Statfold";
        Title = "Statfold Model Railway Event";
        ImagePreview = "IMG_3383-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MelinLlechi));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Birchwood));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.DevilsBridge));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.DorehillStStevens));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.FallMill));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.FortWhiting));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NatfordTMD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HamptonEnd));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Spilsby));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttonBankTMD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TurtleBay));

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
            Date = new DateTime(2023, 04, 01),
            Paragraph = "Visited the The Statfold Model Railway Event on the 1st, 2nd April, lots of amazing models displays.",
            Link = $"{Constants.ModelEvents}/20230401-Statfold/index.html",
            ModelEvent = this,
        };
    }
}