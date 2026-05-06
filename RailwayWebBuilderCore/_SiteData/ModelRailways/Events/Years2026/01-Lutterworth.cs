using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Years2026;

public class Lutterworth2026 : ModelEventPageDetails, IBlogger
{
    public Lutterworth2026()
    {
        Name = "Lutterworth Railway Society";
        Location = new LutterworthSportsCentre();
        EventDates = "Sat 9th May 2026";
        Descrption = "Lutterworth Railway Society Event";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2026-05-09 Lutterworth";
        TripDate = new DateTime(2026, 05, 09);
        YouTubeLink = "";
        ImageFolder = "20260509-Lutterworth";
        Title = "Lutterworth Railway Society Event";
        ImagePreview = "";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Brinklow));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.KelvinGroveToThompsonStreet));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.RugbyCentral));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Sidsend));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.ShauKeiWanTramway));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BettwsRoad));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MortonYardHillFarm));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Kingsworth));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.GreenwoodGardenRailway));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SpionKop));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Lutterworth Railway Society",
           });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Lutterworth Railway Society Event",
            Date = new DateTime(2026, 05, 09),
            Paragraph = "Lutterworth Railway Society Model Show",
            Link = $"{Constants.ModelEvents}/20260509-Lutterworth/index.html",
            ModelEvent = this,
        };
    }
}