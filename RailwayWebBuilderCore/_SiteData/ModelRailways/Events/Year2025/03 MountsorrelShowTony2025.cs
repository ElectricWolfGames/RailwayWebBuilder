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
            YouTubeLink = "https://www.youtube.com/embed/wIkAFwhOKK0";
            ImageFolder = "20250510-MountsorrelTony";
            Title = "Mountsorrel Tony Trains 2025";
            ImagePreview = "Byway-MPD.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BywayMPD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CroxleyHallDepot));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ModularLayoutNCMA));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttonBankTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TanyBwlch));

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
                Paragraph = "Join us for a fun-filled day at the Mountsorrel and Rothley Community Heritage Centre as we explore the Tony Trains Model Show! From intricately detailed model railways to hands-on exhibits and vintage displays, this event is a must-see for train enthusiasts of all ages.",
                Link = $"{Constants.ModelEvents}/20250510-MountsorrelTony/index.html",
                ModelEvent = this,
            };
        }
    }
}