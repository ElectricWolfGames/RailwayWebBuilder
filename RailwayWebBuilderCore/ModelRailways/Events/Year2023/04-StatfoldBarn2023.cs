using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2023
{
    public class StatfoldBarn2023 : ModelEventPageDetails, IBlogger
    {
        public StatfoldBarn2023()
        {
            Name = "Statfold Model Railway Event";
            Location = new StatfoldBarnRailway();
            EventDates = "1th April 2023";
            Descrption = "Statfold Model Railway Event";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-04-01 Statfold Model Railway Event";
            TripDate = new DateTime(2023, 04, 01);
            YouTubeLink = "https://www.youtube.com/embed/OU8kW0bMvXg";
            ImageFolder = "20230401-Statfold";
            Title = "Statfold Model Railway Event";
            ImagePreview = "IMG_3383-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNames.MelinLlechi, Gauges.SM32, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Birchwood, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.DevilsBridge, Gauges.OO9_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.DorehillStStevens, Gauges.OO9_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.FallMill, Gauges.OO9_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.FortWhiting, Gauges.OO9_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.NatfordTMD, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.HamptonEnd, Gauges.G_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.Spilsby, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.SuttonBankTMD, Gauges.OO_Gauge, true));
            Layouts.Add(new LayoutDetails(LayoutNames.TurtleBay, Gauges.OO9_Gauge, true));

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
                Date = new DateTime(2023, 04, 01),
                Paragraph = "Visited the The Statfold Model Railway Event on the 1st, 2nd April, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20230401-Statfold/index.html",
                ModelEvent = this,
            };
        }
    }
}