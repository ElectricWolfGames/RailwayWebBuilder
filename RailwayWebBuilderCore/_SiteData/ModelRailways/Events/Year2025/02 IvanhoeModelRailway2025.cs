using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2025
{
    public class IvanhoeModelRailway2025 : ModelEventPageDetails, IBlogger
    {
        public IvanhoeModelRailway2025()
        {
            Name = "Ivanhoe Model Railway Society";
            Location = new TheMountsorrelMemorialCentre();
            EventDates = "8th / 9th March";
            Descrption = "Ivanhoe Model Railway Society at Mountsorrel.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2025-03-08 Ivanhoe Model Railway Society";
            TripDate = new DateTime(2025, 03, 08);
            YouTubeLink = "https://www.youtube.com/embed/68hWKNOHESY";
            ImageFolder = "20250308-Mountsorrel";
            Title = "Ivanhoe Model Railway Society 2025";
            ImagePreview = "IMG_7953-Stonesby-Magna-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Birchwood));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bradley));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BreganbachImSchwarzwald));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BrinkleyTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DoeLea));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.EbbolsLaneTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GlenBogle));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HartshillBank));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.IngleberryEnd));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Johannesdorf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KnypeBridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MethonSouth));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NorthRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Notgotaname));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Salzgrabe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthMillfields));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StonesbyMagna));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TheStationMaster));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ThomastheTankEngine));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TroddinnickDries));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.VintageTrainCollection));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WesloSteel));
            

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Ivanhoe Model Railway Society"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Ivanhoe Model Railway Society",
                Date = new DateTime(2025, 03, 08),
                Paragraph = "Visited The Ivanhoe Model Railway Society event on the 8th and 9th March, Fantastic People, Amazing layouts",
                Link = $"{Constants.ModelEvents}/20250308-Mountsorrel/index.html",
                ModelEvent = this,
            };
        }
    }
}