using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022
{
    public class Statfold2022 : ModelEventPageDetails, IBlogger
    {
        public Statfold2022()
        {
            Name = "Statfold Model Railway Event";
            Location = new StatfoldBarnRailway();
            EventDates = "9th April 2022";
            Descrption = "Statfold Model Railway Event";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-04-09 Statfold Model Railway Event";
            TripDate = new DateTime(2022, 04, 07);
            YouTubeLink = "https://www.youtube.com/embed/8giNIWlU7Wo";
            ImageFolder = "20220409-Statfold";
            Title = "Statfold Model Railway Event";
            ImagePreview = "P4097587-thumb.JPG";

            Layouts.Add(new LayoutDetails("Appleton Dene", Gauges.O_Gauge, "Appleton Dene"));
            Layouts.Add(new LayoutDetails("Arley", Gauges.OO_Gauge, "Arley"));
            Layouts.Add(new LayoutDetails("Burlish Road", Gauges.O_Gauge, "Burlish Road"));
            Layouts.Add(new LayoutDetails("Campbell Quarry", Gauges._16mm, "Campbell Quarry"));
            Layouts.Add(new LayoutDetails("Caroline Concrete", Gauges.O_Gauge, "Caroline Concrete"));
            Layouts.Add(new LayoutDetails("Coleford", Gauges.OO9_Gauge, "Coleford"));
            Layouts.Add(new LayoutDetails("Cregwir", Gauges.OO_Gauge, "Cregwir"));
            Layouts.Add(new LayoutDetails("Duxbury", Gauges.OO_Gauge, "Duxbury"));
            Layouts.Add(new LayoutDetails("Fairlie Syniad Da", Gauges.OO9_Gauge, "Fairlie Syniad Da"));
            Layouts.Add(new LayoutDetails("Grenstad", Gauges.N_Gauge, "Grenstad"));
            Layouts.Add(new LayoutDetails("Gresty Bridge", Gauges.OO_Gauge, "Gresty Bridge"));
            Layouts.Add(new LayoutDetails("Hackworth (Jutland St)", Gauges.OO_Gauge, "HackWorth"));
            Layouts.Add(new LayoutDetails("Halland", Gauges._45mm, "Halland"));
            Layouts.Add(new LayoutDetails("Hambleden Valley", Gauges.OO_Gauge, "Hambleden Valley"));
            Layouts.Add(new LayoutDetails("Heanor South", Gauges.OO_Gauge, "Heanor South"));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KarolinaFalls, "Karolina Falls"));
            Layouts.Add(new LayoutDetails("Knowles Hill Colliery", Gauges.OO_Gauge, "Knowles Hill Colliery"));
            Layouts.Add(new LayoutDetails("Medway Quay", Gauges.O_Gauge, "Medway Quay"));
            Layouts.Add(new LayoutDetails("Merstone and Ventnor", Gauges.OO_Gauge, "Merstone and Ventnor"));
            Layouts.Add(new LayoutDetails("Middle Elmton", Gauges.N_Gauge, "Middle Elmton"));
            Layouts.Add(new LayoutDetails("Quorn Magna", Gauges.OO_Gauge, "Quorn Magna"));
            Layouts.Add(new LayoutDetails("Ridge Lane", Gauges.OO9_Gauge, "Ridge Lane"));
            Layouts.Add(new LayoutDetails("Rush Green Colliery", Gauges.OO_Gauge, "Rush Green Colliery"));
            Layouts.Add(new LayoutDetails("Scole", Gauges.O_Gauge, "Scole"));
            Layouts.Add(new LayoutDetails("Sixpenny Handley", Gauges.OO_Gauge, "Sixpenny Handley"));
            Layouts.Add(new LayoutDetails("South Wigston", Gauges.OO_Gauge, "South Wigston"));
            Layouts.Add(new LayoutDetails("Southgate Park", Gauges.OO_Gauge, "Southgate Park"));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SuttonBankTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TanyBwlch));
            Layouts.Add(new LayoutDetails("Tramline", Gauges.OO_Gauge, "Tramline"));
            Layouts.Add(new LayoutDetails("Tryffan Ddu", Gauges.OO9_Gauge, "Tryffan Ddu"));
            Layouts.Add(new LayoutDetails("Ulvyard", Gauges.OO9_Gauge, "Ulvyard"));
            Layouts.Add(new LayoutDetails("Upson Down Tramway Museum", Gauges._3mm, "Upson Down Tramway Museum"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Statfold Model Railway Event",
               });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Statfold Model Railway Event",
                Date = new DateTime(2022, 04, 09),
                Paragraph = "Visited the The Statfold Model Railway Event on the 9th, 10th April, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20220409-Statfold/index.html",
                ModelEvent = this,
            };
        }
    }
}