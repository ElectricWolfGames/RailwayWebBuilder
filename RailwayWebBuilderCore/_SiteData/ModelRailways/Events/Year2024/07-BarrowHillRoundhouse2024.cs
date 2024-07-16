using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class BarrowHillRoundhouse2024 : ModelEventPageDetails, IBlogger
    {
        public BarrowHillRoundhouse2024()
        {
            Name = "Deltic Preservation Society, BarrowHill";
            Location = new BarrowHillRoundhouse();
            EventDates = "13th, 14th July";
            Descrption = "Deltic Preservation Society";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-07-13 Deltic Preservation";
            TripDate = new DateTime(2024, 07, 13);

            YouTubeLink = "https://www.youtube.com/embed/01cz3nQJIo8";
            ImageFolder = "20240713-BarrowHill";
            Title = "Deltic Preservation Society 2024";
            ImagePreview = "IMG_6646-Brinkley-Town-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FalconRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Padsbridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CowleyYard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CoalHillWest));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Boston_Maine));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WadsleyBridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GoodleyLaneTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BrinkleyTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ShawbridgeJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LittleCalumet));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Deltic Preservation Society", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Deltic Preservation Society Model Railway",
                Date = new DateTime(2024, 07, 14),
                Paragraph = "We visited the Barrow Hill Roundhouse, to see the Deltic Preservation Society model show.",
                Link = $"{Constants.ModelEvents}/20240713-BarrowHill/index.html",
                ModelEvent = this,
            };
        }
    }
}