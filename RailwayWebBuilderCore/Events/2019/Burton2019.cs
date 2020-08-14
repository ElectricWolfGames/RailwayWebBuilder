using RailwayWebBuilder.Data;
using System;

namespace RailwayWebBuilderCore.Events._2019
{
    public class Burton2019 : ModelEventPageDetails
    {
        public Burton2019()
        {
            Name = "Burton Model Railex";
            EventLocation = new LatitudeLongitude(52.807752, -1.631799);
            EventAddress = "The National Brewery Centre, Horninglow Street, Burton Upon Trent, DE14 1NG";
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
            MetaDetails = Descrption;
        }
    }
}
