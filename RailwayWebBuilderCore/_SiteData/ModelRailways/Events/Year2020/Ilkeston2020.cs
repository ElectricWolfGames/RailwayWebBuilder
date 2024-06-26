﻿using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2020
{
    public class Ilkeston2020 : ModelEventPageDetails, IBlogger
    {
        public Ilkeston2020()
        {
            Name = "Ilkeston (Woodside) Model Railway Club";
            Location = new HeanorMinersWelfareIlkeston();
            EventDates = "23rd February 2020";
            Descrption = "Heanor Miners Welfare, Ilkeston Road, Heanor, Derbyshire DE75 7DT";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2020-02-23 Ilkeston (Woodside) Model Railway Club";
            TripDate = new DateTime(2020, 02, 23);
            YouTubeLink = "https://www.youtube.com/embed/K-yUlJL_O6I";
            ImageFolder = "20200223-Ilkeston";
            Title = "Ilkeston (Woodside) Model Railway Club";
            ImagePreview = "P2237873-Avyn-A-Llyin-Ilkeston-thumb.JPG";

            Layouts.Add(new LayoutDetails("Thomas the Tank Layout", Gauges.OO_Gauge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Neuburg));
            Layouts.Add(new LayoutDetails("Avyn-A-Llyin", Gauges.OO9_Gauge, "03 Avyn-A-Llyin"));
            Layouts.Add(new LayoutDetails("Rothbury", Gauges.OO_Gauge, "04 Rothbury"));
            Layouts.Add(new LayoutDetails("Brookfield N (USA Based)", Gauges.NONE, "06 Brookfield N"));
            Layouts.Add(new LayoutDetails("Poplar Sidings", Gauges.OO_Gauge, "07 Poplar Sidings"));
            Layouts.Add(new LayoutDetails("Glenellen Castle", Gauges.N_Gauge, "08 Glenellen Castle"));
            Layouts.Add(new LayoutDetails("Winter and Summer Hornby", Gauges.Dublo3Rail, "11 Winter and Summer Hornby Dublo 3 Rail"));
            Layouts.Add(new LayoutDetails("Malcolm Hughes Vintage Trains", Gauges.Mixed_Gauge, "10 Malcolm Hughes Vintage Trains"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Ilkeston", "Ilkeston (Woodside) Model Railway Club", "Ilkeston (Woodside) Model Railway", "Heanor Miners Welfare", "Heanor Model Railway" });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Ilkeston (Woodside) Model Railway Club",
                Date = new DateTime(2020, 02, 24),
                Paragraph = "Visited the Ilkeston Model Railway Club event on the 23 feburay, very cool",
                Link = $"{Constants.ModelEvents}/20200223-Ilkeston/index.html",
                ModelEvent = this,
                Carousel = "P2237873 Avyn-A-Llyin Ilkeston.JPG",
                CarouselText = "Ilkeston (Woodside) Model Railway Club"
            };
        }
    }
}