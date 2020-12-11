using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2020
{
    public class Syston2020 : ModelEventPageDetails, IBlogger
    {
        public Syston2020()
        {
            Name = "Syston Model Railway Society";
            Location = new SilebyCommunityCentre();
            EventDates = "15th February 2020";
            Descrption = "Leicester Model Railway Show. Sileby Community Centre, High ST, Sileby, Leicester. LE12 7RX";
            ImagesPath = Constants.DriveLetter + @"Trains\eWolfModelRailwayWeb\Data\ModelEvents\2020-02-15 Syston Model Railway Society";
            TripDate = new DateTime(2020, 02, 16);
            YouTubeLink = "https://www.youtube.com/embed/i6PBrCMCTHg";
            ImageFolder = "20200215-Syston";
            Title = "Syston Model Railway Society 2020";
            ImagePreview = "P2157640-Newton-east-Syston-model-railway-thumb.JPG";

            Layouts.Add(new LayoutDetails("Cumanavago", Gauges.O_Gauge));
            Layouts.Add(new LayoutDetails("Lisworth Bay", Gauges.N_Gauge, "01 Lisworth Bay"));
            Layouts.Add(new LayoutDetails("Southgate DMU", Gauges.OO_Gauge, "02 Southgate Dmu"));
            Layouts.Add(new LayoutDetails("Newtown East", Gauges.OO_Gauge, "03 Newton East"));
            Layouts.Add(new LayoutDetails("Netherwood Sidings", Gauges.O_Gauge, "04 Netherwood Sidings"));
            Layouts.Add(new LayoutDetails("Tudwich Road Sidings", Gauges.O_Gauge, "05 Tudwick Road Sidings"));
            Layouts.Add(new LayoutDetails(LayoutNames.Myton, Gauges.OO_Gauge, "06 Myton"));
            Layouts.Add(new LayoutDetails("Power Station", Gauges.N_Gauge, "07 Power Station"));
            Layouts.Add(new LayoutDetails("Heath Green", Gauges.OO_Gauge, "08 Heath Green"));
            Layouts.Add(new LayoutDetails("Tennis Court Sidings", Gauges.N_Gauge, "09 Tennis Court Sidings"));
            Layouts.Add(new LayoutDetails("Karolina Falls", Gauges.On30_Gauge, "10 Karolina Falls"));
            Layouts.Add(new LayoutDetails("Harrowby Hill MPD", Gauges.OO_Gauge, "12 Harrowby Hill MPD"));
            Layouts.Add(new LayoutDetails("Kozel Cement", Gauges.HO_Gauge, "13 Kozel Cement"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Syston", "Syston Model Railway Society", "Leicester Model Railway Show" });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Syston Model Railway Event",
                Date = new DateTime(2020, 02, 16),
                Paragraph = "Visted the Syston Model Railway event on the 15 feburay, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20200215-Syston/index.html",
                ModelEvent = this,
                Carousel = "P2157640 NewtonEast SystonModelRailway.JPG",
                CarouselText = "Syston Model Railway Event"
            };
        }
    }
}