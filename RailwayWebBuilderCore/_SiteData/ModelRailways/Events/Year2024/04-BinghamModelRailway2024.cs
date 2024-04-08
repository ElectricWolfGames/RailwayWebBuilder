using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class BinghamModelRailway2024 : ModelEventPageDetails, IBlogger
    {
        public BinghamModelRailway2024()
        {
            Name = "Bingham Model Railway Club";
            Location = new BinghamModelRailwayClub();
            EventDates = "6th / 7th April";
            Descrption = "Bingham Model Railway Club's 15th Annual Show";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-04-06 Bingham Model Railway Club";
            TripDate = new DateTime(2024, 04, 06);
            YouTubeLink = "https://www.youtube.com/embed/ZjDfHXRny5w";
            ImageFolder = "20240406-Cotgrave";
            Title = "Bingham Model Railway Show 2024";
            ImagePreview = "IMG_5837-Doe-Lea-thumb.JPG";


            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ashtown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BoxworksWharf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bregstadt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bridges));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Burdock));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DentonSidings));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DoeLea));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HarbourneStMary));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HawtonLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LimbyFields));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LittlePointWharf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewtonFolly));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BlueHeron));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Victoria));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Bingham Model Railway Show 2024"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Bingham Model Railway Show 2024",
                Date = new DateTime(2024, 04, 06),
                Paragraph = "Visited The Bingham Model Railway Club's 15th Annual Show",
                Link = $"{Constants.ModelEvents}/20240406-Cotgrave/index.html",
                ModelEvent = this,
            };
        }
    }
}