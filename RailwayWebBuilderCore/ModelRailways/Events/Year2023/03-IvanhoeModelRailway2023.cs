using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;
using System.Windows.Controls;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2023
{
    public class IvanhoeModelRailway2023 : ModelEventPageDetails, IBlogger
    {
        public IvanhoeModelRailway2023()
        {
            Name = "Ivanhoe Model Railway Society";
            Location = new TheMountsorrelMemorialCentre();
            EventDates = "11th / 12th March";
            Descrption = "Ivanhoe Model Railway Society at Mountsorrel.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-03-11 Ivanhoe Model Railway Society";
            TripDate = new DateTime(2023, 03, 11);
            YouTubeLink = "https://www.youtube.com/embed/????";
            ImageFolder = "20230311-Mountsorrel";
            Title = "Ivanhoe Model Railway Society 2023";
            ImagePreview = "????.JPG";

            Layouts.Add(new LayoutDetails(LayoutNames.Bankwood, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.BearCreek, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Boghampton, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Burdock, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.CarriageandWagon, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.EuDepot, Gauges.O_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.GardenHalt, Gauges.O165_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.HeanorSouth, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Hopeless, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.KnotLittlefield, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.LionelVintageCollection, Gauges.O_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.LymebrookYard, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.MillfieldYard, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.BuggleskellyModels, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Silverton, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.TanYFron, Gauges.OO9_Narrow_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Ullapool, Gauges.O_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.WhealKist, Gauges.OO9_Narrow_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.LondonRoad, Gauges.OO_Gauge, true));
            
            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Ivanhoe Model Railway Society"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Ivanhoe Model Railway Society",
                Date = new DateTime(2023, 03, 11),
                Paragraph = "Visited The Ivanhoe Model Railway Society event on the 11th and 12th March, Fantastic People, Amazing layouts",
                Link = $"{Constants.ModelEvents}/20230311-Mountsorrel/index.html",
                ModelEvent = this,
            };
        }
    }
}