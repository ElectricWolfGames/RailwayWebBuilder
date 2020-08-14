using RailwayWebBuilder.Data;
using System;

namespace RailwayWebBuilderCore.Events._2019
{
    public class Woodthorpe2019 : ModelEventPageDetails
    {
        public Woodthorpe2019()
        {
            Name = "Woodthorpe Model Railway Club";
            EventLocation = new LatitudeLongitude(52.985928, -1.143651);
            EventAddress = "Sherwood Community Centre,  Mansfield Road, Sherwood, Nottingham, NG5 3FN";
            EventDates = "26 October 2019";
            Descrption = "Woodthorpe Model Railway Club";
            ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-10-26 Woodthorpe Model Railway Club";
            TripDate = new DateTime(2019, 10, 26);
            YouTubeLink = "https://www.youtube.com/embed/rXa8fywTtLg";
            ImageFolder = "20191026-Woodthorpe";
            Title = "Woodthorpe Model Railway Club 2019";
            ImagePreview = "PA266852-Woodthorpe-Model-thumb.jpg";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Woodthorpe", "Woodthorpe Model Railway Club" });
            MetaDetails = Descrption;
        }
    }
}
