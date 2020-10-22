using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2019
{
    public class Loughborough2019 : ModelEventPageDetails
    {
        public Loughborough2019()
        {
            Name = "Loughborough Model Railway Exhibition";
            Location = new GrammarSchoolLoughborough();
            EventDates = "31st August and 1st September 2019";
            Descrption = "Loughborough Model Railway Exhibition";
            ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-08-31 Loughborough model railway exhibition 2019";
            TripDate = new DateTime(2019, 08, 31);
            YouTubeLink = "https://www.youtube.com/embed/oFrYD7NMH-8";
            ImageFolder = "20190831-Loughborough";
            Title = "Loughborough Model Railway Exhibition 2019";
            ImagePreview = "P8315301-thumb.jpg";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Loughborough", "Loughborough Model Railway Exhibition", });
        }
    }
}
