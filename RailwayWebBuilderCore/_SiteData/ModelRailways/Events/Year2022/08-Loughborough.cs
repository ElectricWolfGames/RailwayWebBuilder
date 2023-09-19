using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2022
{
    public class Loughborough2022 : ModelEventPageDetails, IBlogger
    {
        public Loughborough2022()
        {
            Name = "Soar Valley Model Railway Club annual exhibition";
            Location = new GrammarSchoolLoughborough();
            EventDates = "20th and 21st August 2022";
            Descrption = "Loughborough Model Railway Exhibition, Soar Valley Model Railway Club annual exhibition";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-08-20 Loughborough model railway exhibition 2022";
            TripDate = new DateTime(2022, 08, 20);

            YouTubeLink = "https://www.youtube.com/embed/17Dc92uPPnw";
            ImageFolder = "20220820-Loughborough";
            Title = "Soar Valley Model Railway Club 2022";
            ImagePreview = "P8210480-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brookthorpe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FredstoneLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.JamesStreet));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ThePowerStation));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Neuburg));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Uppingham));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PurgatoryPeak));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AyleettEnd));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BlaendareRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BritanniaMill));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DilhornColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DorehillStStevens));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FrantonMill));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HollandBeck));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KettleLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NoPlace));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PassageLaneTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PedwardineForest));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Pencoed));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PennaLaneTMD));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthgatesDmu));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthWigston));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Tremawn));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Silverton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StJohns));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ThomasQuarry));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.UndermilkWood));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HartonGill));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NormanColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.VintageOGauge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GartonBahn));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Loughborough",
                "Loughborough Model Railway Exhibition", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Soar Valley Model Railway Club",
                Date = new DateTime(2022, 08, 20),
                Paragraph = "We visited the Loughborough Model Railway Exhibition event on the 20th, 21th August 2022, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20220820-Loughborough/index.html",
                ModelEvent = this,
            };
        }
    }
}