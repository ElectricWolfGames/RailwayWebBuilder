using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2019
{
    public class Lichfield2019 : ModelEventPageDetails
    {
        public Lichfield2019()
        {
            Name = "Lichfield Model Railways";
            Location = new TheLifeChurchLichfield();
            EventDates = "21st September 2019";
            Descrption = "Trent Valley Model Railway Society at The Life Church, Netherstowe, Lichfield, Staffordshire WS13 6TS";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2019-09-21 Lichfield Model Railways";
            TripDate = new DateTime(2019, 09, 21);
            YouTubeLink = "https://www.youtube.com/embed/26L2peFd8og";
            ImageFolder = "20190921-Lichfield";
            Title = "Lichfield Model Railways 2019";
            ImagePreview = "P9215780-thumb.JPG";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Lichfield", "Lichfield Model Railways", "Trent Valley Model Railway Society", "TVMRS" });
        }
    }
}