using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class ElizabethanRailwaySociety2024 : ModelEventPageDetails, IBlogger
    {
        public ElizabethanRailwaySociety2024()
        {
            Name = "The Elizabethan Railway Society 2024";
            Location = new TheSummitCentreKirkby();
            EventDates = "Sat 12th - Sun 13th October 2024";
            Descrption = "The Elizabethan Railway Society 2024";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-10-13 Elizabethan";
            TripDate = new DateTime(2024, 10, 13);

            YouTubeLink = "https://www.youtube.com/embed/";
            ImageFolder = "20241013-Elizabethan";
            Title = "The Elizabethan Railway Society 2024";
            ImagePreview = "-thumb.JPG";
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Northfields));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MedenVale));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BirdsFolly));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttonInAshfield));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LlanforenShed));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HeanorSouth));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BritanniaMills));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KirkbyInAshfield));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Hindlow));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KnowlesHillColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Uppingham));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Warley", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "The Elizabethan Railway Society 2024",
                Date = new DateTime(2024, 10, 13),
                Paragraph = "Large Model show at the Warley at Statfold Model Railway Show",
                Link = $"{Constants.ModelEvents}/20241013-Elizabethan/index.html",
                ModelEvent = this,
            };
        }
    }
}