using RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Events.Year2026;

public class Loughborough2026 : ModelEventPageDetails, IBlogger
{
    public Loughborough2026()
    {
        Name = "Soar Valley Model Railway Club annual exhibition";
        Location = new GrammarSchoolLoughborough();
        EventDates = "22th and 23st August 2026";
        Descrption = "Loughborough Model Railway Exhibition, Soar Valley Model Railway Club annual exhibition";
        ImagesPath = Constants.RawDataPath + @"ModelEvents\2026-08-22 Loughborough model railway exhibition";
        TripDate = new DateTime(2026, 08, 22);
        RawPath = "E:\\Trains\\Photos - Main\\2026\\2026-08-22 Soar Valley Model Railway\\";

        YouTubeLink = "https://www.youtube.com/embed/???????";
        ImageFolder = "20260822-Loughborough";
        Title = "Soar Valley Model Railway Club 2026";
        ImagePreview = "IMG_????-thumb.JPG";

        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BowatersPaperMill));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.BurtonLeicesterJunction));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Corsham));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.CWSDairies));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Effingborough));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.EffinghamStreet));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.EvingtonStJohn));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.GothamCentral));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.GreatCentral));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.HackworthTrafalgarTerrace));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Kostritzer));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LoftCityCentralRailway));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LosTanimals));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.LowndesRode));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.MeadenFalls));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NetherwoodSidings));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.NewchapelJunction));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Oakenshaw));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.OakhurstTown));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.OliverHill));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.PettleworthDowns));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Rolvenden));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SandsideQuarry));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Scarlington));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Smaulton));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SmethurstJunction));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SpionKop));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Splott));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.SternPoint));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.StMarys));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.TwoLocks));
        Layouts.Add(new LayoutDetails(LayoutNamesEnums.Twygg));

        Keywords.AddRange(ModelEventKeywords());
        Keywords.AddRange(new string[] {
            "Loughborough",
            "Loughborough Model Railway Exhibition",
            "Loughborough Model Railway Exhibition 2026",
            "Soar Valley Model Railway Club",
            "Soar Valley Model Railway Club annual exhibition",
            "Loughborough Grammar School",
            "Leicestershire", });
    }

    public IBlog GetBlog()
    {
        return new Blog
        {
            Name = "Soar Valley Model Railway Club",
            Date = new DateTime(2026, 08, 15),
            Paragraph = "We visited the Loughborough Model Railway Exhibition event on the 22th, 23th August 2026, lots of amazing models displays.",
            Link = $"{Constants.ModelEvents}/20260822-Loughborough/index.html",
            ModelEvent = this,
        };
    }
}