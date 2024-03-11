using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class IvanhoeModelRailway2024 : ModelEventPageDetails, IBlogger
    {
        public IvanhoeModelRailway2024()
        {
            Name = "Ivanhoe Model Railway Society";
            Location = new TheMountsorrelMemorialCentre();
            EventDates = "9th / 10th March";
            Descrption = "Ivanhoe Model Railway Society at Mountsorrel.";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-03-09 Ivanhoe Model Railway Society";
            TripDate = new DateTime(2024, 03, 09);
            YouTubeLink = "https://www.youtube.com/embed/vMfDTv50Aa0";
            ImageFolder = "20240309-Mountsorrel";
            Title = "Ivanhoe Model Railway Society 2024";
            ImagePreview = "IMG_5431-thumb.JPG";



            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ArnoldLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bank));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BurchGreen));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Claremont));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.CroftMillWharf));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cumanavago));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.GranbyLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HillportGoods));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.JustFour));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LinwoodLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewDalbyResearchDivision));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Oscarton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ShawbridgeJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TemplegateWagonWorks));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Torcy));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LionelVintageCollection));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.WelbyLane));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Westwick));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TheSidings));

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
                Date = new DateTime(2024, 03, 09),
                Paragraph = "Visited The Ivanhoe Model Railway Society event on the 9th and 10th March, Fantastic People, Amazing layouts",
                Link = $"{Constants.ModelEvents}/20240309-Mountsorrel/index.html",
                ModelEvent = this,
            };
        }
    }
}