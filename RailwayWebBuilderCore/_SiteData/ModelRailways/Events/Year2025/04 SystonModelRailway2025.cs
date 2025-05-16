using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2025
{
    public class SystonModelRailway2025 : ModelEventPageDetails, IBlogger
    {
        public SystonModelRailway2025()
        {
            Name = "Syston Model Railway 2025";
            Location = new RootsatThorpeFarmThorpe();
            EventDates = "16th / 17th May";
            Descrption = "Syston Model Railway";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2025-05-16 Syston";
            TripDate = new DateTime(2025, 05, 16);
            YouTubeLink = "https://www.youtube.com/embed/";
            ImageFolder = "20250516-System";
            Title = "Syston Model Railway 2025";
            ImagePreview = "Byway-MPD.jpg";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BrittaniaMills));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StMarys));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ChaddesleyCorbett));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WithamLayout));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Oldmarket));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HighLevelJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Willevie2));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.EssexBrick));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ano));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Model Railway"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Syston Model Railway 2025",
                Date = new DateTime(2025, 05, 16),
                Paragraph = "",
                Link = $"{Constants.ModelEvents}/20250516-System/index.html",
                ModelEvent = this,
            };
        }
    }
}