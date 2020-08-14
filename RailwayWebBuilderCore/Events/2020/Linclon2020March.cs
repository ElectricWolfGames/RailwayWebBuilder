using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Data;
using RailwayWebBuilder.Interfaces;
using System;

namespace RailwayWebBuilderCore.Events._2020
{
    public class Linclon2020March : ModelEventPageDetails, IBlogger
    {
        public Linclon2020March()
        {
            Name = "Newark - Lincoln Model Rail Club General Exhibition";
            EventLocation = new LatitudeLongitude(53.098709, -0.768302);
            EventAddress = "Lady Eastwood Pavilion, Newark Showground, Drove Lane, Newark, Nottinghamshire NG24 2NY";
            EventDates = "Saturday 29th February & Sunday 1st March 2020";
            Descrption = "Lincoln Model Rail Club General Exhibition";
            ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2020-02-29 NewarkLincolnModelRailClub";
            TripDate = new DateTime(2020, 02, 29);
            YouTubeLink = "https://www.youtube.com/embed/gHkPSd4i8_0";
            ImageFolder = "20200229-Newark";
            Title = "Lincoln Model Rail Club General Exhibition 2020";
            ImagePreview = "P2298149-Dorehill-sT-Lincoln-model-rail-club.Stephens-Lincoln-model-rail-club-thumb.JPG";

            Layouts.Add(new LayoutDetails("Ambleton Vale", Gauges.N_Gauge, "Ambleton Vale"));
            Layouts.Add(new LayoutDetails("Arnold Lane", Gauges.OO_Gauge, "Arnold Lane"));
            Layouts.Add(new LayoutDetails("Barden", Gauges.O_Gauge, "Barden"));
            Layouts.Add(new LayoutDetails("Bedford Road", Gauges.O_Gauge, "Bedford Road"));
            Layouts.Add(new LayoutDetails("Blackgang", Gauges.NONE, "Blackgang"));
            Layouts.Add(new LayoutDetails("Breydon", Gauges.OO_Gauge, "Breydon"));
            Layouts.Add(new LayoutDetails("Caroline Concrete Works", Gauges.NONE, "Caroline Concrete Works"));
            Layouts.Add(new LayoutDetails("Croft Mill Wharf", Gauges.O_Gauge, "Croft Mill Wharf"));
            Layouts.Add(new LayoutDetails("Croft SPA", Gauges.N_Gauge, "Croft SPA"));
            Layouts.Add(new LayoutDetails("Cumanavago", Gauges.OO_Gauge));
            Layouts.Add(new LayoutDetails("Dorehill ST. Stephens", Gauges.OO_Gauge, "Dorehill ST. Stephens"));
            Layouts.Add(new LayoutDetails("Emsworth", Gauges.OO_Gauge, "Emsworth"));
            Layouts.Add(new LayoutDetails("Glenellen Castle", Gauges.N_Gauge, "Glenellen Castle"));
            Layouts.Add(new LayoutDetails("Hartley Poole", Gauges.N_Gauge, "Hartley Poole"));
            Layouts.Add(new LayoutDetails("Hollington Quarry", Gauges.OO9_Gauge));
            Layouts.Add(new LayoutDetails("Kleine Rundfahrt", Gauges.N_Gauge_Continental, "Kleine Rundfahrt"));
            Layouts.Add(new LayoutDetails("Kozel Cement", Gauges.HO_Gauge));
            Layouts.Add(new LayoutDetails("Norman Colliery", Gauges.O_Gauge, "Norman Colliery"));
            Layouts.Add(new LayoutDetails("Northallerton", Gauges.N_Gauge, "Northallerton"));
            Layouts.Add(new LayoutDetails("Obervaz", Gauges.H0mNarrowGauge, "Obervaz"));
            Layouts.Add(new LayoutDetails("Roberts Road", Gauges.N_Gauge, "Roberts Road"));
            Layouts.Add(new LayoutDetails("Salthaven Quay", Gauges.O_Gauge, "Salthaven Quay"));
            Layouts.Add(new LayoutDetails("Shaken & Not Stirred", Gauges.NONE));
            Layouts.Add(new LayoutDetails("Spilsby", Gauges.NONE, "Spilsby"));
            Layouts.Add(new LayoutDetails("Stamford East", Gauges.N_Gauge, "Stamford East"));
            Layouts.Add(new LayoutDetails("The Power Station", Gauges.N_Gauge, "The Power Station"));
            Layouts.Add(new LayoutDetails("Thorncliffe", Gauges.OO_Gauge, "Thorncliffe"));
            Layouts.Add(new LayoutDetails("Welby Lane", Gauges.NONE, "Welby Lane"));
            Layouts.Add(new LayoutDetails("Worlds Way", Gauges.OO_Gauge, "Worlds Way"));
            Layouts.Add(new LayoutDetails(LayoutNames.Myton, Gauges.OO_Gauge, "Myton"));

            Keywords.AddRange(ModelEventKeywords());
            Keywords.AddRange(new string[] { "Linclon", "L&DMRC", "Lincoln Model Rail Club", "Newark Showground", "General Exhibition" });
            MetaDetails = Descrption;
        }

        public IBlog GetBlog()
        {
            return new Blog
            {
                Name = "Lincoln Model Rail Club General Exhibition",
                Date = new DateTime(2020, 02, 29),
                Paragraph = "Big show at the Newark Showground, this time it's the Lincoln Model Rail Club General Exhibition.",
                Link = $"{Constants.ModelEvents}/20200229-Newark/index.html",
                ModelEvent = this,
                Carousel = "P2298149 DorehillST LincolnModelRailClub.Stephens LincolnModelRailClub.JPG",
                CarouselText = "Lincoln Model Rail Club General Exhibition"
            };
        }
    }
}
