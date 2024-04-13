using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
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
            EventDates = "1th April 2023";
            Descrption = "Statfold Model Railway Event";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-04-13 Statfold Model Railway Event";
            TripDate = new DateTime(2024, 04, 13);
            YouTubeLink = "https://www.youtube.com/embed/ZjDfHXRny5w";
            ImageFolder = "20240413-Statfold";
            Title = "Statfold Model Railway Event 2024";
            ImagePreview = "IMG_5837-Doe-Lea-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LawriesMechanicalMarvelsNcmaModularRailway));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ashgate));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BadDurkheimBetriebshof));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Beckwick));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BeddgelertJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BorthAberdovey_YnyslasRailway));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Breydon));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BuxtonRailex));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Corrish));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DawlishWarren));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DerwentRailway));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FairTmiddlin));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FennStreetYard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GlenadamDistillery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GranbyLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Hodgemead));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HornbyMagazinesNewLayout));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LappingWorks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LeighStGeorge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NantGWRtheyrn));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.OakhurstTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PortDinorwic));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RoofersLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RustonandHornsby_SheafIronworks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SanClemente));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ShovelHeadHalt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StEtienne_En_Caux));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StPhilips));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StanleyMidland));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TheCharnwoodBranch));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TheEndoftheEstate));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Torreycombe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WestCoastCement));

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
                Date = new DateTime(2024, 04, 13),
                Paragraph = "Visited Statfold's Model Railway Exhibition ",
                Link = $"{Constants.ModelEvents}/20240413-Statfold/index.html",
                ModelEvent = this,
            };
        }
    }
}