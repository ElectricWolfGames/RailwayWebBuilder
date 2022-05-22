using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2022
{
    public class Lutterworth2022 : ModelEventPageDetails, IBlogger
    {
        public Lutterworth2022()
        {
            Name = "Lutterworth Railway Society";
            Location = new LutterworthSportsCentre();
            EventDates = "Sat 21st - Sun 22nd May 2022";
            Descrption = "Lutterworth Railway Society Event";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-05-21 Lutterworth";
            TripDate = new DateTime(2022, 05, 21);
            YouTubeLink = "https://www.youtube.com/embed/???";
            ImageFolder = "20220521-Lutterworth";
            Title = "Lutterworth Railway Society Event";
            ImagePreview = "P5218659-thumb.JPG";

            Layouts.Add(new LayoutDetails("Museum of Transport", Gauges.OO_Gauge, "Museum of Transport"));
            Layouts.Add(new LayoutDetails("Re united Biscuits", Gauges.OO_Gauge, "Re united Biscuits"));
            Layouts.Add(new LayoutDetails("South Wigston", Gauges.OO_Gauge, "South Wigston"));
            Layouts.Add(new LayoutDetails("Rugby Central", Gauges.N_Gauge, "Rugby Central"));
            Layouts.Add(new LayoutDetails("Johnston", Gauges.OO_Gauge, "Johnston"));
            Layouts.Add(new LayoutDetails("Brinklow", Gauges.N_Gauge, "Brinklow"));
            Layouts.Add(new LayoutDetails("Chippenham Junction", Gauges.N_Gauge, "Chippenham Junction"));
            Layouts.Add(new LayoutDetails("Cucknoe", Gauges.N_Gauge, "Cucknoe"));
            Layouts.Add(new LayoutDetails("Whartson Hall", Gauges.N_Gauge, "Whartson Hall"));
            Layouts.Add(new LayoutDetails("Southgate DMU", Gauges.OO_Gauge, "Southgate DMU"));
            Layouts.Add(new LayoutDetails("Le Club 143 and Seen Better days", Gauges.N_Gauge, "Le Club 143 and Seen Better days"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Lutterworth Railway Society",
               });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Lutterworth Railway Society Event",
                Date = new DateTime(2022, 05, 21),
                Paragraph = "Lutterworth Railway Society - 50th Anniversary Model Railway and Classic Bus Exhibition",
                Link = $"{Constants.ModelEvents}/20220521-Lutterworth/index.html",
                ModelEvent = this,
            };
        }
    }
}