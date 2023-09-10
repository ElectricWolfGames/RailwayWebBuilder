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

            YouTubeLink = "https://www.youtube.com/embed/?????";
            ImageFolder = "20230910-Burton";
            Title = "Burton Model Railex 2023";
            ImagePreview = "?-thumb.JPG";


            Layouts.Add(new LayoutDetails(LayoutNamesEnums.LittleBurton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Pipeyard));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bishopston));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.BottomoftheBarrel));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.RiddletoOldTown));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DragonsLair));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Thomas));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Effingborough));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.HackworthJutlandStreet));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Marmagne));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Baykolands));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.EllaRoad));

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