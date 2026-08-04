using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Years2026;

public class BattlefieldLineMoodleShow2026 : ModelEventPageDetails, IBlogger
{
    public BattlefieldLineMoodleShow2026()
    {
        Name = "Battlefield Line Moodle Show 2026";
        Location = new MarketBosworthStation();
        EventDates = "Sat 8th Aug 2026";
        Descrption = "Battlefield Line Moodle Show ";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2026-08-08 Battlefield";
        TripDate = new DateTime(2026, 08, 08);
        YouTubeLink = "https://www.youtube.com/embed/?????????";
        ImageFolder = "20260808-Battlefield";
        Title = "Battlefield Line Moodle Show 2026";
        ImagePreview = "??????-thumb.JPG";

        /*
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.DaisyLaneTMD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BellswoodEnd));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Bluish Moor));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Avyn-A-Llyin));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Byway MPD));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Illie Town));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Two Locks));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Sharnbrook Summit));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Fareford North));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Carding Road));

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Rawdon));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Penlee Harbour));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Kelvin Grove));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Underground Ernie));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.World of Sodor));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.5″ and 7 1/4″ Miniature Railway));

*/
        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "",
           });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Battlefield Line Moodle Show 2026",
            Date = new DateTime(2026, 08, 08),
            Paragraph = "Battlefield Line Moodle Show 2026",
            Link = $"{Constants.ModelEvents}/20260808-Battlefield/index.html",
            ModelEvent = this,
        };
    }
}