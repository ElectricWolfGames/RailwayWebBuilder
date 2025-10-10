using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2020;

public class Syston2020 : ModelEventPageDetails, IBlogger
{
    public Syston2020()
    {
        Name = "Syston Model Railway Society";
        Location = new SilebyCommunityCentre();
        EventDates = "15th February 2020";
        Descrption = "Leicester Model Railway Show. Sileby Community Centre, High ST, Sileby, Leicester. LE12 7RX";
        ImagesPath = Configuration.Constants.RawDataPath + @"ModelEvents\2020-02-15 Syston Model Railway Society";
        TripDate = new DateTime(2020, 02, 16);
        YouTubeLink = "https://www.youtube.com/embed/i6PBrCMCTHg";
        ImageFolder = "20200215-Syston";
        Title = "Syston Model Railway Society 2020";
        ImagePreview = "P2157640-Newton-east-Syston-model-railway-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Cumanavago));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LisworthBay, "01 Lisworth Bay"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SouthgateDMU, "02 Southgate Dmu"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewtownEast, "03 Newton East"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NetherwoodSidings, "04 Netherwood Sidings"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TudwichRoadSidings, "05 Tudwick Road Sidings"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Myton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.ThePowerStation));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HeathGreen, "08 Heath Green"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TennisCourtSidings, "09 Tennis Court Sidings"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KarolinaFalls, "10 Karolina Falls"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HarrowbyHillMPD, "12 Harrowby Hill MPD"));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KozelCement, "13 Kozel Cement"));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] { "Syston", "Syston Model Railway Society", "Leicester Model Railway Show" });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Syston Model Railway Event",
            Date = new DateTime(2020, 02, 16),
            Paragraph = "Visited the Syston Model Railway event on the 15 feburay, lots of amazing models displays.",
            Link = $"{Configuration.Constants.ModelEvents}/20200215-Syston/index.html",
            ModelEvent = this,
            Carousel = "P2157640 NewtonEast SystonModelRailway.JPG",
            CarouselText = "Syston Model Railway Event"
        };
    }
}