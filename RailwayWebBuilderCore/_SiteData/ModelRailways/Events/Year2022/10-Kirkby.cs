using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022
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
            YouTubeLink = "https://www.youtube.com/embed/CnT0kyIlDQY";
            ImageFolder = "20221008-Kirkby";
            Title = "The Elizabethan Railway Society Exhibition 2022";
            ImagePreview = "PA081440-2022-10-08-Oscarton-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNames.Ambleside, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.StMichaelsVale, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Brunshafen, Gauges.HO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.BrittanniaMills, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.SheffieldVictoria, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Burgedorf, Gauges.HOe_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Elmfield, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Oscarton, Gauges.N_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Brassingdale, Gauges.OO_Gauge, true));
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
                Paragraph = "Visited The Elizabethan Railway Society Exhibition event on the 08th October, Fantastic People, Amazing layouts",
                Link = $"{Constants.ModelEvents}/20221008-Kirkby/index.html",
                ModelEvent = this,
            };
        }
    }
}