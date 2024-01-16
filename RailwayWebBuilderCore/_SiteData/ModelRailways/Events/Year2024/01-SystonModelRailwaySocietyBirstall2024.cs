using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2024
{
    public class SystonModelRailwaySocietyBirstall2024 : ModelEventPageDetails, IBlogger
    {
        public SystonModelRailwaySocietyBirstall2024()
        {
            Name = "Syston Model Railway Society Birstall 2024";
            Location = new BurtonRailwaySociety();
            EventDates = "13 January";
            Descrption = "Syston Model Railway Society";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2024-01-13 Syston Model Railway";
            TripDate = new DateTime(2024, 01, 13);

            YouTubeLink = "https://www.youtube.com/embed/szV4kYLdhsE";
            ImageFolder = "20240113-Birstall";
            Title = "Syston Model Railway Society 2024";
            ImagePreview = "vlcsnap-2024-01-16-16h39m48s461.jpg";

            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Burdock));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.Silverton));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DoeLea));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TrainSpotting));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.EllaRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.ShovelHeadHalt));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.DunsfoldRoad));
            Layouts.Add(new LayoutDetails(LayoutNamesEnums.TemplegateWagonWorks));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Syston Model Railway Society", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Syston Model Railway Society",
                Date = new DateTime(2024, 01, 13),
                Paragraph = "We visited the Syston Model Railway Society on the 13th January 2024, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20240113-Birstall/index.html",
                ModelEvent = this,
            };
        }
    }
}