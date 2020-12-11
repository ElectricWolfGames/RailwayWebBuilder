﻿using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2019
{
    public class Kettering2019 : ModelEventPageDetails
    {
        public Kettering2019()
        {
            Name = "Kettering Model Railway Exhibition";
            Location = new GreenfieldsPrimarySchoolKettering();
            EventDates = "14th September 2019";
            Descrption = "Kettering and District Model Railway Society Annual Model Railway Exhibition";
            ImagesPath = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-09-14 Kettering Model Railway Exhibition";
            TripDate = new DateTime(2019, 09, 14);
            YouTubeLink = "https://www.youtube.com/embed/DzjtAOowBKE";
            ImageFolder = "20190914-Kettering";
            Title = "Kettering Model Railway Exhibition 2019";
            ImagePreview = "P9145561-thumb.jpg";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Kettering", "Kettering Model Railway Exhibition", });
        }
    }
}