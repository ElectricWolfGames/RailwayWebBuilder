using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022
{
    public class Lutterworth2022 : ModelEventPageDetails, IBlogger
    {
        public Lutterworth2022()
        {
            Name = "Lutterworth Railway Society";
            Location = new LutterworthSportsCentre();
            EventDates = "Sat 21st - Sun 22nd May 2022";
            Descrption = "Lutterworth Railway Society Event";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-05-21 Lutterworth";
            TripDate = new DateTime(2022, 05, 21);
            YouTubeLink = "https://www.youtube.com/embed/FNbWud340d4";
            ImageFolder = "20220521-Lutterworth";
            Title = "Lutterworth Railway Society Event";
            ImagePreview = "P5218659-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MuseumofTransport));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ReunitedBiscuits));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthWigston));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RugbyCentral));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Johnston));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brinklow));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ChippenhamJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cucknoe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WhartsonHall));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthgateDMU, "Southgate DMU"));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LeClub143andSeenBetterdays));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Lutterworth Railway Society",
               });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Lutterworth Railway Society Event",
                Date = new DateTime(2022, 05, 21),
                Paragraph = "Lutterworth Railway Society - 50th Anniversary Model Railway and Classic Bus Exhibition",
                Link = $"{Constants.ModelEvents}/20220521-Lutterworth/index.html",
                ModelEvent = this,
            };
        }
    }
}