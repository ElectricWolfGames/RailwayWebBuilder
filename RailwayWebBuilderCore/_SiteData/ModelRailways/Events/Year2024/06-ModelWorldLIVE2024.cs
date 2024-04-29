using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class ModelWorldLIVE2024 : ModelEventPageDetails, IBlogger
    {
        public ModelWorldLIVE2024()
        {
            Name = "Model World LIVE";
            Location = new NecBirmingham();
            EventDates = "27th April 2024";
            Descrption = "Model World LIVE";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-04-27 Model World LIVE";
            TripDate = new DateTime(2024, 04, 27);
            YouTubeLink = "https://www.youtube.com/embed/??????????";
            ImageFolder = "20240427-ModelLive";
            Title = "Model World LIVE 2024";
            ImagePreview = "IMG_5993-Glenadam-Distillery-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MakingTracksTheFinalFrontier));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BlairAthollTowardsDrumochter));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewvaddonParkway));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PatrickLaneFlaskTerminal));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Allerby));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TwelvemilBridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NatfordTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FairlieSyniadDa));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DagnellEnd));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BristolTemplecombeRoadShed));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Northbridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DobsonBridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Beckwick));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Scarlington));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RumblingBridge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SparkelGerman));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.OldElmPark));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RustonandHornsbySheafIronworks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Kinlochloggen));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NormanColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bury_ThornandSon));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GrestenAustria));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Stodmarsh));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SanClementeAmerica));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Hallard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Mothecombe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FordonHillRailway));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FenceHouses));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GrindleyBrook));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LittleAshton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MelinLlechi));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.IadThat));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ProvidenceColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BeijiaoChina));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StFayreRhianne));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FairportWharf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DublingtonGoodsStation));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.InglenookShunting));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Model World LIVE 2024"
                });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Model World LIVE 2024",
                Date = new DateTime(2024, 04, 27),
                Paragraph = "Visited Model World LIVE at the NEC",
                Link = $"{Constants.ModelEvents}/20240427-ModelLive/index.html",
                ModelEvent = this,
            };
        }
    }
}