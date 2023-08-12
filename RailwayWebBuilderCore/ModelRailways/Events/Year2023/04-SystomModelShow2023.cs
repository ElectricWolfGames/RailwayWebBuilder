using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2023
{
    public class SystomModelShow2023 : ModelEventPageDetails, IBlogger
    {
        public SystomModelShow2023()
        {
            Name = "Syston Model Railway Society";
            Location = new RootsatThorpeFarm();
            EventDates = "29th/30th April 2023";
            Descrption = "Syston Model Railway Society";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-04-29 Syston Model Railway Society";
            TripDate = new DateTime(2023, 04, 29);
            YouTubeLink = "https://www.youtube.com/embed/YInvka3Bhbg";
            ImageFolder = "20230429-Syston";
            Title = "Syston Model Railway Society";
            ImagePreview = "IMG_3725-2023-04-29-Neuburg-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Neuburg));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Axmouth));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Martini));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NormanColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SeenBetterDays));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brookfield));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CookEnd));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BregenbachImSchwarzald));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LinwoodLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Birchwood));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Tamaro));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Syston Model Railway Society",
               });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Syston Model Railway Society Event",
                Date = new DateTime(2023, 04, 29),
                Paragraph = "Visited the The Syston Model Railway Society at Roots at Thorpe Farm, Thorpe.",
                Link = $"{Constants.ModelEvents}/20230429-Syston/index.html",
                ModelEvent = this,
            };
        }
    }
}