using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2021
{
    public class Hinckley2021 : ModelEventPageDetails, IBlogger
    {
        public Hinckley2021()
        {
            Name = "Hinckley Model Railway Show";
            Location = new TheForrayanCentreHinckley();
            EventDates = "30th October 2021";
            Descrption = "Hinckley Model Railway Show at Hinckley, Leicestershire .";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2021-10-30 Hinckley Model Railway Show";
            TripDate = new DateTime(2021, 10, 30);
            YouTubeLink = "https://www.youtube.com/embed/GYXOvy2pk6w";
            ImageFolder = "20211030-Hinckley";
            Title = "Hinckley Model Railway Show 2021";
            ImagePreview = "PA305806-2021-10-30-Hinckley-model-show-thumb.JPG";

            Layouts.Add(new LayoutDetails("Buxworth", Gauges.O_Gauge, "01 Buxworth"));
            Layouts.Add(new LayoutDetails("The Electric Tram", Gauges.N_Gauge, "07 The Electric Tram"));
            Layouts.Add(new LayoutDetails("Robinson Heath", Gauges.N_Gauge, "09 Robinson Heath"));
            Layouts.Add(new LayoutDetails("Canal Park and Station", Gauges.OO_Gauge, "10 Canal Park and Station"));
            Layouts.Add(new LayoutDetails("Badgers Hollow", Gauges.OO_Gauge, "15 Badgers Hollow"));
            Layouts.Add(new LayoutDetails("Magna Park", Gauges.OO_Gauge, "17 Magna Park"));
            Layouts.Add(new LayoutDetails("St Ruth", Gauges.N_Gauge, "18 St. Ruth"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "The Forrayan Centre",
                "Hinckley Model Railway Show",
                "Railway Show at Hinckley" });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Hinckley Model Railway Show 2021",
                Date = new DateTime(2021, 10, 30),
                Paragraph = "Visited the The Hinckley Model Railway Show on the 30th October, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20211030-Hinckley/index.html",
                ModelEvent = this,
            };
        }
    }
}