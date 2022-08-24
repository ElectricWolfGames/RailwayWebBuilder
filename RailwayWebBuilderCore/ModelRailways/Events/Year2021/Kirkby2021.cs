using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2021
{
    public class Kirkby2021 : ModelEventPageDetails, IBlogger
    {
        public Kirkby2021()
        {
            Name = "The Elizabethan Railway Society Exhibition";
            Location = new TheSummitCentreKirkby();
            EventDates = "10th October 2021";
            Descrption = "The Elizabethan Railway Society Exhibition at Kirkby-In-Ashfield.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2021-10-10 Kirkby-In-Ashfield Model Railway Exhibition";
            TripDate = new DateTime(2021, 10, 10);
            YouTubeLink = "https://www.youtube.com/embed/7NUNQLOYvyM";
            ImageFolder = "20211010-Kirkby";
            Title = "The Elizabethan Railway Society Exhibition 2021";
            ImagePreview = "PA105301-2021-10-10-Kirkby-in-ashfield-North-road-thumb.JPG";

            Layouts.Add(new LayoutDetails("Sutton-in-Ashfield Town", Gauges.OO_Gauge, "Sutton-in-Ashfield Town"));
            Layouts.Add(new LayoutDetails("Cumanavago", Gauges.OO_Gauge, "Cumanavago"));
            Layouts.Add(new LayoutDetails("Westbrook", Gauges.N_Gauge, "Westbrook"));
            Layouts.Add(new LayoutDetails("North Road", Gauges.N_Gauge, "North Road"));
            Layouts.Add(new LayoutDetails("Avyn-a-llyin", Gauges.OO9_Gauge, "Avyn-a-llyin"));
            Layouts.Add(new LayoutDetails("Karolina Falls", Gauges.On30_Gauge, "Karolina Falls"));
            Layouts.Add(new LayoutDetails("St. Marys", Gauges.O165_Gauge, "St. Marys"));
            Layouts.Add(new LayoutDetails("Industrivej", Gauges.HO_Gauge, "Industrivej"));
            Layouts.Add(new LayoutDetails("High Level Junction", Gauges.N_Gauge, "High Level Junction"));
            Layouts.Add(new LayoutDetails("Cardboard Works", Gauges.N_Gauge, "Cardboard Works"));
            Layouts.Add(new LayoutDetails("Kirkby-in-Ashfield MPD", Gauges.OO_Gauge, "Kirkby-in-Ashfield MPD"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Kirkby-In-Ashfield",
                "The Elizabethan Railway Society Exhibition",
                "Kirkby-In-Ashfield Model Railway" });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "The Elizabethan Railway Society Exhibition",
                Date = new DateTime(2021, 10, 10),
                Paragraph = "Visited the The Elizabethan Railway Society Exhibition event on the 10th October, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20211010-Kirkby/index.html",
                ModelEvent = this,
            };
        }
    }
}