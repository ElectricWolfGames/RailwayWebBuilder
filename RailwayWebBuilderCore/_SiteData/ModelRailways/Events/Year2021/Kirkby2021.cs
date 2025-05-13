using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2021
{
    public class Kirkby2021 : ModelEventPageDetails, IBlogger
    {
        public Kirkby2021()
        {
            Name = "The Elizabethan Railway Society Exhibition";
            Location = new TheSummitCentreKirkby();
            EventDates = "10th October 2021";
            Descrption = "The Elizabethan Railway Society Exhibition at Kirkby-In-Ashfield.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2021-10-10 Kirkby-In-Ashfield Model Railway Exhibition";
            TripDate = new DateTime(2021, 10, 10);
            YouTubeLink = "https://www.youtube.com/embed/7NUNQLOYvyM";
            ImageFolder = "20211010-Kirkby";
            Title = "The Elizabethan Railway Society Exhibition 2021";
            ImagePreview = "PA105301-2021-10-10-Kirkby-in-ashfield-North-road-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttoninAshfieldTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cumanavago));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Westbrook));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NorthRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AvynALlyin));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KarolinaFalls, "Karolina Falls"));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StMarys));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Industrivej));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HighLevelJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CardboardWorks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KirkbyInAshfieldMPD));

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
                Date = new DateTime(2021, 10, 10),
                Paragraph = "Visited the The Elizabethan Railway Society Exhibition event on the 10th October, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20211010-Kirkby/index.html",
                ModelEvent = this,
            };
        }
    }
}