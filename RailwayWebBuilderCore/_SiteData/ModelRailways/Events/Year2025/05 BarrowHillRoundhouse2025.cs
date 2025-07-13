using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2025
{
    public class BarrowHillRoundhouse2025 : ModelEventPageDetails, IBlogger
    {
        public BarrowHillRoundhouse2025()
        {
            Name = "Deltic Preservation Society, BarrowHill";
            Location = new BarrowHillRoundhouse();
            EventDates = "12th, 13th July";
            Descrption = "Deltic Preservation Society";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2025-07-13 Deltic Preservation";
            TripDate = new DateTime(2025, 07, 13);

            YouTubeLink = "https://www.youtube.com/embed/??????";
            ImageFolder = "20250713-BarrowHill";
            Title = "Deltic Preservation Society 2025";
            ImagePreview = "???????.JPG";
            CreateLayoutFolders = "E:\\Trains\\Photos - Main\\2025\\2025-07-13 Barrow Hill\\";
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NapierRoadEarly));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PassageLaneTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Wardwood));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HindLeighYard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthgatePark));

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RiverKwaiBridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RoundtreesSidinngs));

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WittsEnd));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MartiniJunction));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Deltic Preservation Society", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Deltic Preservation Society Model Railway",
                Date = new DateTime(2025, 07, 14),
                Paragraph = "We visited the Barrow Hill Roundhouse, to see the Deltic Preservation Society model show.",
                Link = $"{Constants.ModelEvents}/20250713-BarrowHill/index.html",
                ModelEvent = this,
            };
        }
    }
}