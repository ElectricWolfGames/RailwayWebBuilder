using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2023
{
    public class Loughborough2023 : ModelEventPageDetails, IBlogger
    {
        public Loughborough2023()
        {
            Name = "Soar Valley Model Railway Club annual exhibition";
            Location = new GrammarSchoolLoughborough();
            EventDates = "12th and 13st August 2023";
            Descrption = "Loughborough Model Railway Exhibition, Soar Valley Model Railway Club annual exhibition";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-08-12 Loughborough model railway exhibition";
            TripDate = new DateTime(2023, 08, 12);

            YouTubeLink = "https://www.youtube.com/embed/X7ncKuT-0Oo";
            ImageFolder = "20230812-Loughborough";
            Title = "Soar Valley Model Railway Club 2023";
            ImagePreview = "IMG_4349-Soar-vally-model-show-Smallwood-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RibbleheadLayout));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.IlfracombeEast));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Barnwood));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brookfield));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BurtononTrent));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HartleyPooleToo));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewvaddonParkway));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.OakwoodLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Rockcliffe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StRuth));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BregenbachImSchwarzald));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KleineRundfahrt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Ishinaka));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AtherleyNarrows));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SanClemente));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Wolfstatt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GlenmoreParva));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HackworthTrafalgarTerrace));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HilltonTMDandMod));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.IllieTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LinwoodLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LoughboroughMidland));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Myton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Smallwood));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthgatePark));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Thorncliffe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CharnwoodForest));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewchapelJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CookEnd));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WolfLowe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RoofersLane));

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
                Date = new DateTime(2023, 08, 15),
                Paragraph = "We visited the Loughborough Model Railway Exhibition event on the 12th, 13th August 2023, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20230812-Loughborough/index.html",
                ModelEvent = this,
            };
        }
    }
}