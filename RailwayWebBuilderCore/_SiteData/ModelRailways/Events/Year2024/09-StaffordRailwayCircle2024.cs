using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Windows.Controls;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class StaffordRailwayCircle2024 : ModelEventPageDetails, IBlogger
    {
        public StaffordRailwayCircle2024()
        {
            Name = "Stafford Railway Circle";
            Location = new StaffordCountyShowground();
            EventDates = "Sat 28th - Sun 29th September";
            Descrption = "Stafford Railway Circle";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-09-28 StaffordRailwayCircle";
            TripDate = new DateTime(2024, 09, 28);

            YouTubeLink = "https://youtu.be/9p3IBUISavk";
            ImageFolder = "20240928-StaffordRailwayCircle";
            Title = "Stafford Railway Circle 2024";
            ImagePreview = "IMG_7235-Con-Yard-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AtherleyNarrows));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BirminghamMoorSt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BottomoftheBarrel));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BregenbachImSchwarzwald));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BurlishRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Callaton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CalstockHaltonQuay));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CampbellsQuarry));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ConYard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CrimsonRD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.EdenbridgeTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FredstoneLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GrangeLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HogsmeadonSodor));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Industrivej));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Kaninchenbau));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Kinlochewe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LisworthBay));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LittleAire));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LlanfairCaereinion));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Lottenbirge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MacclesfieldHibelRD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MeyrickRD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewDalbyResearchDivision));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewchapelJCT));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NormanColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.OilDrumLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PlasBrondanw));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PlasterMill));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PortWilliam));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Portsea));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RedbridgeWharf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RedwickHalt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SanClemente));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Scarlington));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Sheperdswell));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Spilsby));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Splott));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StJohns));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StSeeb));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SwissPass));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TanYCoed));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ThePipeWorks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TregurraDries));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TremoyJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WestmoorJCT));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WillowbrookMarsh));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Whithorn));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Narrow7mmGaugeAssociation));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Stafford Railway Circle", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Stafford Railway Circle",
                Date = new DateTime(2024, 09, 28),
                Paragraph = "Large Model show at the Stafford County Showground.",
                Link = $"{Constants.ModelEvents}/20240928-StaffordRailwayCircle/index.html",
                ModelEvent = this,
            };
        }
    }
}