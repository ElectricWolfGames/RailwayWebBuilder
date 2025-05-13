using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2020
{
    public class Linclon2020March : ModelEventPageDetails, IBlogger
    {
        public Linclon2020March()
        {
            Name = "Newark - Lincoln Model Rail Club General Exhibition";
            Location = new NewarkShowground();
            EventDates = "Saturday 29th February & Sunday 1st March 2020";
            Descrption = "Lincoln Model Rail Club General Exhibition";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2020-02-29 NewarkLincolnModelRailClub";
            TripDate = new DateTime(2020, 02, 29);
            YouTubeLink = "https://www.youtube.com/embed/gHkPSd4i8_0";
            ImageFolder = "20200229-Newark";
            Title = "Lincoln Model Rail Club General Exhibition 2020";
            ImagePreview = "P2298149-Dorehill-sT-Lincoln-model-rail-club.Stephens-Lincoln-model-rail-club-thumb.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AmbletonVale));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ArnoldLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Barden));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BedfordRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Blackgang));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Breydon));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CarolineConcreteWorks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CroftMillWharf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CroftSPA));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cumanavago));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DorehillStStevens));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Emsworth));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GlenellenCastle));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HartleyPoole));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HollingtonQuarry));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KleineRundfahrt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.KozelCement));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NormanColliery));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Northallerton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Obervaz));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RobertsRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.SalthavenQuay));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ShakenNotStirred));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Spilsby));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.StamfordEast));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ThePowerStation));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Thorncliffe));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WelbyLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WorldsWay));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Myton));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Linclon", "L&DMRC", "Lincoln Model Rail Club", "Newark Showground", "General Exhibition" });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Lincoln Model Rail Club General Exhibition",
                Date = new DateTime(2020, 02, 29),
                Paragraph = "Big show at the Newark Showground, this time it's the Lincoln Model Rail Club General Exhibition.",
                Link = $"{Constants.ModelEvents}/20200229-Newark/index.html",
                ModelEvent = this,
                Carousel = "P2298149 DorehillST LincolnModelRailClub.Stephens LincolnModelRailClub.JPG",
                CarouselText = "Lincoln Model Rail Club General Exhibition"
            };
        }
    }
}