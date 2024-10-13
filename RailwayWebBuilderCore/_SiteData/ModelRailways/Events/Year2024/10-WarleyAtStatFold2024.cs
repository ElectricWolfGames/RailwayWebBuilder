using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class WarleyAtStatFold2024 : ModelEventPageDetails, IBlogger
    {
        public WarleyAtStatFold2024()
        {
            Name = "Warley At Statfold 2024";
            Location = new StatfoldBarnRailway();
            EventDates = "Sat 12th - Sun 13th October 2024";
            Descrption = "Warley at Statfold Model Railway Show";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-10-12 WarleyAtStatfold";
            TripDate = new DateTime(2024, 10, 12);

            YouTubeLink = "https://www.youtube.com/embed/v8mV0fJE4Ug";
            ImageFolder = "20241012-WarleyAtStatfold";
            Title = "Warley at Statfold Model Railway Show 2024";
            ImagePreview = "IMG_7450-Weekend-Yard-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BorringtonByTheSea));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RumbowEdge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Sellraintal));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BroadwaterJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GravellyOak));

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WeekendYard));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Warley", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Warley at Statfold Model Railway Show",
                Date = new DateTime(2024, 10, 12),
                Paragraph = "Large Model show at the Warley at Statfold Model Railway Show",
                Link = $"{Constants.ModelEvents}/20241012-WarleyAtStatfold/index.html",
                ModelEvent = this,
            };
        }
    }
}