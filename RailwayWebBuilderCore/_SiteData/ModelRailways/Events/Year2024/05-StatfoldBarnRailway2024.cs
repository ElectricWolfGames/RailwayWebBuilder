using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class StatfoldBarnRailway2024 : ModelEventPageDetails, IBlogger
    {
        public StatfoldBarnRailway2024()
        {
            Name = "Statfold Model Railway Event";
            Location = new StatfoldBarnRailway();
            EventDates = "13th April 2024";
            Descrption = "Statfold Model Railway Event";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-04-13 Statfold Model Railway Event";
            TripDate = new DateTime(2024, 04, 13);
            YouTubeLink = "https://www.youtube.com/embed/tqCRymKf_O4";
            ImageFolder = "20240413-Statfold";
            Title = "Statfold Model Railway Event 2024";
            ImagePreview = "IMG_5993-Glenadam-Distillery-thumb.JPG";

           
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Beckwick));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BeddgelertJunction));
            

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Statfold Model Railway Event 2024"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Statfold Model Railway Event 2024",
                Date = new DateTime(2024, 04, 16),
                Paragraph = "Visited Statfold's Model Railway Exhibition ",
                Link = $"{Constants.ModelEvents}/20240413-Statfold/index.html",
                ModelEvent = this,
            };
        }
    }
}