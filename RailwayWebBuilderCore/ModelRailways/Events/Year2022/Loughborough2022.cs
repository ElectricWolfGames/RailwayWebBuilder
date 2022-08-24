using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.EventLocations;
using System;

namespace RailwayWebBuilderCore.ModelRailways.Events.Year2022
{
    public class Loughborough2022 : ModelEventPageDetails, IBlogger
    {
        public Loughborough2022()
        {
            Name = "Soar Valley Model Railway Club annual exhibition";
            Location = new GrammarSchoolLoughborough();
            EventDates = "20th and 21st August 2022";
            Descrption = "Loughborough Model Railway Exhibition, Soar Valley Model Railway Club annual exhibition";
            ImagesPath = Constants.RawDataPath + @"ModelEvents\2022-08-20 Loughborough model railway exhibition 2022";
            TripDate = new DateTime(2022, 08, 20);

            YouTubeLink = "https://www.youtube.com/embed/17Dc92uPPnw";
            ImageFolder = "20220820-Loughborough";
            Title = "Soar Valley Model Railway Club 2022";
            ImagePreview = "P8210480-thumb.JPG";

            Layouts.Add(new LayoutDetails("Brookthorpe", Gauges.N_Gauge, "24 Brookthorpe"));
            Layouts.Add(new LayoutDetails("Fredstone Lane", Gauges.N_Gauge, "11 Fredstone Lane"));
            Layouts.Add(new LayoutDetails("James Street", Gauges.N_Gauge, "07 James Street"));
            Layouts.Add(new LayoutDetails(LayoutNames.ThePowerStation, Gauges.N_Gauge, "18 Power Station"));
            Layouts.Add(new LayoutDetails(LayoutNames.Neuburg, Gauges.HO_Gauge, "28 Neuburg"));
            Layouts.Add(new LayoutDetails("Uppingham", Gauges._3mm, "09 Uppingham"));

            Layouts.Add(new LayoutDetails("Purgatory Peak", Gauges.On30_Gauge, "50 Purgatory Peak"));
            Layouts.Add(new LayoutDetails("Ayleett End", Gauges.OO_Gauge, "19 Ayleett End"));
            Layouts.Add(new LayoutDetails("Blaendare Road", Gauges.OO_Gauge, "20 Blaendare Road"));
            Layouts.Add(new LayoutDetails("Britannia Mill", Gauges.OO_Gauge, "25 Britannia Mill"));
            Layouts.Add(new LayoutDetails("Dilhorn Colliery", Gauges.OO_Gauge, "01 Dilhorn Colliery"));
            Layouts.Add(new LayoutDetails("Dore Hill St Stevens", Gauges.OO_Gauge, "10 Dore Hill St Stevens"));
            Layouts.Add(new LayoutDetails("Franton Mill", Gauges.OO_Gauge, "32 Franton Mill"));
            Layouts.Add(new LayoutDetails("Holland Beck", Gauges.OO_Gauge, "31 Holland Beck"));
            Layouts.Add(new LayoutDetails("Kettle Lane", Gauges.OO_Gauge, "03 Kettle Lane"));
            Layouts.Add(new LayoutDetails("No Place", Gauges.OO_Gauge, "13 No Place"));
            Layouts.Add(new LayoutDetails("Passage Lane TMD", Gauges.OO_Gauge, "12 Passage Lane TMD"));
            Layouts.Add(new LayoutDetails("Pedwardine Forest", Gauges.OO_Gauge, "14 Pedwardine Forest"));
            Layouts.Add(new LayoutDetails("Pencoed", Gauges.OO_Gauge, "15 Pencoed"));
            Layouts.Add(new LayoutDetails("Penna Lane TMD", Gauges.OO_Gauge, "02 Penna Lane TMD"));
            Layouts.Add(new LayoutDetails("Southgates Dmu", Gauges.OO_Gauge, "08 Southgates Dmu"));
            Layouts.Add(new LayoutDetails("South Wigston (Now and Then)", Gauges.OO_Gauge, "04 South Wigston (Now and Then)"));
            Layouts.Add(new LayoutDetails("Tremawn", Gauges.OO_Gauge, "17 Tremawn"));
            Layouts.Add(new LayoutDetails("Silverton", Gauges.OO_Gauge, "16 Silverton"));
            Layouts.Add(new LayoutDetails("St Johns", Gauges.OO_Gauge, "26 St Johns"));
            Layouts.Add(new LayoutDetails("Thomas Quarry", Gauges.OO9_Gauge, "22 Thomas Quarry"));
            Layouts.Add(new LayoutDetails("Undermilk Wood", Gauges.OO9_Gauge, "21 Undermilk Wood"));
            Layouts.Add(new LayoutDetails("Harton Gill", Gauges.P4Gauge, "30 Harton Gill"));
            Layouts.Add(new LayoutDetails("Norman Colliery", Gauges.O_Gauge, "27 Norman Colliery"));
            Layouts.Add(new LayoutDetails("Vintage O Gauge", Gauges.O_Gauge, "06 Vintage O Gauge"));
            Layouts.Add(new LayoutDetails("Garton Bahn", Gauges.G_Gauge, "23 Garton Bahn"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] {
                "Loughborough",
                "Loughborough Model Railway Exhibition", });
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Soar Valley Model Railway Club",
                Date = new DateTime(2022, 08, 20),
                Paragraph = "We visited the Loughborough Model Railway Exhibition event on the 20th, 21th August 2022, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20220820-Loughborough/index.html",
                ModelEvent = this,
            };
        }
    }
}