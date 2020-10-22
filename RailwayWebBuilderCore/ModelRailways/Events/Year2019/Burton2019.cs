using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2019
{
    public class Burton2019 : ModelEventPageDetails
    {
        public Burton2019()
        {
            Location = new TheNationalBreweryCentre();
            Name = "Burton Model Railex";
            EventDates = "3rd November 2019";
            Descrption = "Burton Model Railex 2019 at the National Brewery Centre.";
            ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-11-03 BurtonModelRailex";
            TripDate = new DateTime(2019, 11, 03);
            YouTubeLink = "https://www.youtube.com/embed/gADZzAauDuU";
            ImageFolder = "20191103-Burton";
            Title = "Burton Model Railex 2019";
            ImagePreview = "PB037041-Burton-model-railex-thumb.jpg";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Burton", "Burton Model Railex" });
        }
    }
}
