using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2022
{
    public class Kirkby2022 : ModelEventPageDetails, IBlogger
    {
        public Kirkby2022()
        {
            Name = "The Elizabethan Railway Society Exhibition";
            Location = new TheSummitCentreKirkby();
            EventDates = "8th October 2022";
            Descrption = "The Elizabethan Railway Society Exhibition at Kirkby-In-Ashfield.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-10-08 Kirkby-In-Ashfield Model Railway Exhibition";
            TripDate = new DateTime(2022, 10, 08);
            YouTubeLink = "";
            ImageFolder = "20221008-Kirkby";
            Title = "The Elizabethan Railway Society Exhibition 2022";
            ImagePreview = "PA105301-2021-10-08-Kirkby-in-ashfield-North-road-thumb.JPG";

            Layouts.Add(new LayoutDetails("Ambleside", Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails("St Michaels Vale", Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails("Brunshafen", Gauges.HO_Gauge, true));
            Layouts.Add(new LayoutDetails("Brittannia Mills", Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails("Sheffield Victoria", Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails("Burgedorf", Gauges.HO_Gauge, true));
            Layouts.Add(new LayoutDetails("Elmfield", Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails("Oscarton", Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails("BrassingDale", Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.NormanColliery, Gauges.O_Gauge, true));

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
                Date = new DateTime(2022, 10, 08),
                Paragraph = "Visited the The Elizabethan Railway Society Exhibition event on the 08th October, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20211010-Kirkby/index.html",
                ModelEvent = this,
            };
        }
    }
}