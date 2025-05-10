using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2025
{
    public class MountsorrelShowTony2025 : ModelEventPageDetails, IBlogger
    {
        public MountsorrelShowTony2025()
        {
            Name = "Mountsorrel Tony Trains Model Show";
            Location = new TheMountsorrelMemorialCentre();
            EventDates = "10th / 11th May";
            Descrption = "Mountsorrel Tony Trains Model Show";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2025-05-10 Mountsorrel Tony Trains";
            TripDate = new DateTime(2025, 05, 10);
            YouTubeLink = "https://www.youtube.com/embed/????";
            ImageFolder = "20250510-MountsorrelTony";
            Title = "Mountsorrel Tony Trains 2025";
            ImagePreview = "IMG_7953--thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttonBankTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TanyBwlch));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BywayMPD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ModularLayoutNCMA));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CroxleyHallDepot));


            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Model Railway"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Mountsorrel Tony Trains Model Show",
                Date = new DateTime(2025, 05, 10),
                Paragraph = "",
                Link = $"{Constants.ModelEvents}/2025-05-10 Mountsorrel Tony Trains/index.html",
                ModelEvent = this,
            };
        }
    }
}