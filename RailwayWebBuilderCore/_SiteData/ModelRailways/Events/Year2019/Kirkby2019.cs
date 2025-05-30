﻿using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2019
{
    public class Kirkby2019 : ModelEventPageDetails
    {
        public Kirkby2019()
        {
            Name = "The Elizabethan Railway Society Exhibition";
            Location = new TheSummitCentreKirkby();
            EventDates = "12th October 2019";
            Descrption = "The Elizabethan Railway Society Exhibition at Kirkby-In-Ashfield.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2019-10-12 Kirkby-In-Ashfield Model Railway Exhibition";
            TripDate = new DateTime(2019, 10, 12);
            YouTubeLink = "https://www.youtube.com/embed/yP6tlbtXYxA";
            ImageFolder = "20191012-Kirkby";
            Title = "The Elizabethan Railway Society Exhibition 2019";
            ImagePreview = "PA126400-Willen-end-Kirkby-In-Ashfield-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Barden));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Kirkby-In-Ashfield", "The Elizabethan Railway Society Exhibition", "Kirkby-In-Ashfield Model Railway" });
        }
    }
}