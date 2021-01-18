using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2019
{
    public class Woodthorpe2019 : ModelEventPageDetails
    {
        public Woodthorpe2019()
        {
            Name = "Woodthorpe Model Railway Club";
            Location = new SherwoodCommunityCentreSherwood();
            EventDates = "26 October 2019";
            Descrption = "Woodthorpe Model Railway Club";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2019-10-26 Woodthorpe Model Railway Club";
            TripDate = new DateTime(2019, 10, 26);
            YouTubeLink = "https://www.youtube.com/embed/rXa8fywTtLg";
            ImageFolder = "20191026-Woodthorpe";
            Title = "Woodthorpe Model Railway Club 2019";
            ImagePreview = "PA266852-Woodthorpe-Model-thumb.jpg";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Woodthorpe", "Woodthorpe Model Railway Club" });
        }
    }
}