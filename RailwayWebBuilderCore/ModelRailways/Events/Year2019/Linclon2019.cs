using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2019
{
    public class Linclon2019 : ModelEventPageDetails
    {
        public Linclon2019()
        {
            Name = "Newark - Lincoln Model Rail Club Post Modernisation Exhibition";
            Location = new NewarkShowground();
            EventDates = "19th and 20th October 2019";
            Descrption = "Lincoln Model Rail Club Post Modernisation Exhibition";
            ImagesPath = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-10-19 Newark Model LincolnModelRailClub";
            TripDate = new DateTime(2019, 10, 19);
            YouTubeLink = "https://www.youtube.com/embed/sfhv8iYXiYU";
            ImageFolder = "20191019-Lincoln";
            Title = "Lincoln Model Rail Club 2019";
            ImagePreview = "PA196601-Newark-Model-Lincoln-model-rail-club-Crimson-road-thumb.JPG";

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Linclon", "Lincoln Model Rail Club", "Newark Showground", "Post Modernisation Exhibition" });

            Layouts.Add(new LayoutDetails("Crimson Road", Gauges.NONE, "CrimsonRoad"));
            Layouts.Add(new LayoutDetails("Cumanavago", Gauges.NONE, "Cumanavago"));
            Layouts.Add(new LayoutDetails("Dovington Camp", Gauges.NONE, "DovingtonCamp"));
            Layouts.Add(new LayoutDetails("Eight Dollar Canyon", Gauges.NONE, "EightDollarCanyon"));
            Layouts.Add(new LayoutDetails("Euxton Junction", Gauges.NONE, "EuxtonJunction"));
            Layouts.Add(new LayoutDetails("Gillingbourne", Gauges.NONE, "Gillingbourne"));
            Layouts.Add(new LayoutDetails("Holland Beck", Gauges.NONE, "HollandBeck"));
            Layouts.Add(new LayoutDetails("Illie Town", Gauges.NONE, "IllieTown"));
            Layouts.Add(new LayoutDetails("K Street Yard", Gauges.NONE, "KStreetYard"));
            Layouts.Add(new LayoutDetails("Lea Green Yard", Gauges.NONE, "LeaGreenYard"));
            Layouts.Add(new LayoutDetails("Loch Tat", Gauges.NONE, "LochTat"));
            Layouts.Add(new LayoutDetails("Low Moor", Gauges.NONE, "LowMoor"));
            Layouts.Add(new LayoutDetails("Lynchwood Sidings", Gauges.NONE, "LynchwoodSidings"));
            Layouts.Add(new LayoutDetails("Norton Folgate", Gauges.NONE, "NortonFolgate"));
            Layouts.Add(new LayoutDetails("Oil DrumLane", Gauges.NONE, "OilDrumLane"));
            Layouts.Add(new LayoutDetails("Penna Lane", Gauges.NONE, "PennaLane"));
            Layouts.Add(new LayoutDetails("Sutherland Street", Gauges.NONE, "SutherlandStreet"));
            Layouts.Add(new LayoutDetails("Titheridge Junction", Gauges.NONE, "TitheridgeJunction"));
            Layouts.Add(new LayoutDetails("Weaver Hill", Gauges.NONE, "WeaverHill"));
            Layouts.Add(new LayoutDetails("West Street Station", Gauges.NONE, "WestStreetStation"));
            Layouts.Add(new LayoutDetails("Zlata Vychod", Gauges.NONE, "ZlataVychod"));
        }
    }
}
