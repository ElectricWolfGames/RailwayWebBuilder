using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2020
{
    public class Ilkeston2020 : ModelEventPageDetails, IBlogger
    {
        public Ilkeston2020()
        {
            Name = "Ilkeston (Woodside) Model Railway Club";
            Location = new HeanorMinersWelfareIlkeston();
            EventDates = "23rd February 2020";
            Descrption = "Heanor Miners Welfare, Ilkeston Road, Heanor, Derbyshire DE75 7DT";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2020-02-23 Ilkeston (Woodside) Model Railway Club";
            TripDate = new DateTime(2020, 02, 23);
            YouTubeLink = "https://www.youtube.com/embed/K-yUlJL_O6I";
            ImageFolder = "20200223-Ilkeston";
            Title = "Ilkeston (Woodside) Model Railway Club";
            ImagePreview = "P2237873-Avyn-A-Llyin-Ilkeston-thumb.JPG";

            Layouts.Add(new LayoutDetails("Thomas the Tank Layout", Gauges.OO_Gauge));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Neuburg));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AvynALlyin));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Rothbury));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BrookfieldN));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PoplarSidings));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GlenellenCastle));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WinterandSummerHornby));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MalcolmHughesVintageTrains));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Ilkeston", "Ilkeston (Woodside) Model Railway Club", "Ilkeston (Woodside) Model Railway", "Heanor Miners Welfare", "Heanor Model Railway" });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Ilkeston (Woodside) Model Railway Club",
                Date = new DateTime(2020, 02, 24),
                Paragraph = "Visited the Ilkeston Model Railway Club event on the 23 feburay, very cool",
                Link = $"{Constants.ModelEvents}/20200223-Ilkeston/index.html",
                ModelEvent = this,
                Carousel = "P2237873 Avyn-A-Llyin Ilkeston.JPG",
                CarouselText = "Ilkeston (Woodside) Model Railway Club"
            };
        }
    }
}