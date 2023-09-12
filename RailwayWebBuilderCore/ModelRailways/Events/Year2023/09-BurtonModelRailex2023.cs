using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2023
{
    public class BurtonModelRailex2023 : ModelEventPageDetails, IBlogger
    {
        public BurtonModelRailex2023()
        {
            Name = "Burton Model Railex 2023";
            Location = new BurtonRailwaySociety();
            EventDates = "10 September 2023";
            Descrption = "Burton Railway Society";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2023-09-10 Burton Railway Society";
            TripDate = new DateTime(2023, 09, 10);

            YouTubeLink = "https://www.youtube.com/embed/1VueA8HdUQ8";
            ImageFolder = "20230910-Burton";
            Title = "Burton Model Railex 2023";
            ImagePreview = "IMG_4729-Jutland-Street-thumb.JPG";


            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bishopston));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BottomoftheBarrel));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Effingborough));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.EllaRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HackworthJutlandStreet));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LittleBurton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Marmagne));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Pipeyard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RavensRavine));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.PortWilliamTrebarwithQuarry));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RiddletoOldTown));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Burton Railway Society", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Burton Railway Society",
                Date = new DateTime(2023, 09, 10),
                Paragraph = "We visited the Burton Railway Society on the 10th September 2023, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20230910-Burton/index.html",
                ModelEvent = this,
            };
        }
    }
}