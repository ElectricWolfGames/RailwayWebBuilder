using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2025
{
    public class SystonModelRailwaySocietyBirstall2025 : ModelEventPageDetails, IBlogger
    {
        public SystonModelRailwaySocietyBirstall2025()
        {
            Name = "Syston Model Railway Society Birstall 2025";
            Location = new BirstallSystonModelRailwaySociety();
            EventDates = "18 January";
            Descrption = "Syston Model Railway Society";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2025-01-18 Syston Model Railway";
            TripDate = new DateTime(2025, 01, 18);

            YouTubeLink = "https://www.youtube.com/embed/zX5rtkYbuI4";
            ImageFolder = "20250118-Birstall";
            Title = "Syston Model Railway Society 2025";
            ImagePreview = "IMG_7742-Allsop-&-Sons.JPG";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Glenellen));

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.NorthernJunction));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.AllsopAndSons));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.MedanVale));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.OliverHill));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PortWillian));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Glenties));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.FoxhillColliery));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Syston Model Railway Society", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Syston Model Railway Society",
                Date = new DateTime(2025, 01, 13),
                Paragraph = "We visited the Syston Model Railway Society on the 18th and 19th January 2025, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20250118-Birstall/index.html",
                ModelEvent = this,
            };
        }
    }
}