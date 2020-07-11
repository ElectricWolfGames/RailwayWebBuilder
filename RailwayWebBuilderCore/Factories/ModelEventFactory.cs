using RailwayWebBuilder.Data;
using RailwayWebBuilder.Interfaces;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilder.Factories
{
    public static class ModelEventFactory
    {
        public static IModelEvent CreateBurton2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Burton Model Railex",
                Descrption = "Burton Model Railex 2019 at the National Brewery Centre.",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-11-03 BurtonModelRailex",
                TripDate = new DateTime(2019, 11, 03),
                YouTubeLink = "https://www.youtube.com/embed/gADZzAauDuU",
                ImageFolder = "20191103-Burton",
                Title = "Burton Model Railex 2019",
                ImagePreview = "PB037041-Burton-model-railex-thumb.jpg"
            };
            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Burton", "Burton Model Railex" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateKettering2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Kettering Model Railway Exhibition",
                Descrption = "Kettering and District Model Railway Society Annual Model Railway Exhibition",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-09-14 Kettering Model Railway Exhibition",
                TripDate = new DateTime(2019, 09, 14),
                YouTubeLink = "https://www.youtube.com/embed/DzjtAOowBKE",
                ImageFolder = "20190914-Kettering",
                Title = "Kettering Model Railway Exhibition 2019",
                ImagePreview = "P9145561-thumb.jpg"
            };
            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Kettering", "Kettering Model Railway Exhibition", });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateKirkby2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "The Elizabethan Railway Society Exhibition",
                Descrption = "The Elizabethan Railway Society Exhibition at Kirkby-In-Ashfield.",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-10-12 Kirkby-In-Ashfield Model Railway Exhibition",
                TripDate = new DateTime(2019, 10, 12),
                YouTubeLink = "https://www.youtube.com/embed/yP6tlbtXYxA",
                ImageFolder = "20191012-Kirkby",
                Title = "The Elizabethan Railway Society Exhibition 2019",
                ImagePreview = "PA126400-Willen-end-Kirkby-In-Ashfield-thumb.jpg"
            };
            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Kirkby-In-Ashfield", "The Elizabethan Railway Society Exhibition", "Kirkby-In-Ashfield Model Railway" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateLichfield2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Lichfield Model Railways",
                Descrption = "Trent Valley Model Railway Society at The Life Church, Netherstowe, Lichfield, Staffordshire WS13 6TS",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-09-21 Lichfield Model Railways",
                TripDate = new DateTime(2019, 09, 21),
                YouTubeLink = "https://www.youtube.com/embed/26L2peFd8og",
                ImageFolder = "20190921-Lichfield",
                Title = "Lichfield Model Railways 2019",
                ImagePreview = "P9215780-thumb.jpg"
            };
            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Lichfield", "Lichfield Model Railways", "Trent Valley Model Railway Society", "TVMRS" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateLinclon2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Newark - Lincoln Model Rail Club Post Modernisation Exhibition",
                Descrption = "Lincoln Model Rail Club Post Modernisation Exhibition",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-10-19 Newark Model LincolnModelRailClub",
                TripDate = new DateTime(2019, 10, 19),
                EventAddress = "Lady Eastwood Pavilion, Newark Showground, Drove Lane, Newark, Nottinghamshire NG24 2NY",
                EventDates = "19th and 20th October 2019",
                YouTubeLink = "https://www.youtube.com/embed/sfhv8iYXiYU",
                ImageFolder = "20191019-Lincoln",
                Title = "Lincoln Model Rail Club 2019",
                ImagePreview = "PA196601-Newark-Model-Lincoln-model-rail-club-Crimson-road-thumb.JPG"
            };
            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Linclon", "Lincoln Model Rail Club", "Newark Showground", "Post Modernisation Exhibition" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;

            // TODO: Add more here
            modelPageDetails.Layouts.Add(new LayoutDetails("Crimson Road", Gauges.NONE, "CrimsonRoad"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Cumanavago", Gauges.NONE, "Cumanavago"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Dovington Camp", Gauges.NONE, "DovingtonCamp"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Eight Dollar Canyon", Gauges.NONE, "EightDollarCanyon"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Euxton Junction", Gauges.NONE, "EuxtonJunction"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Gillingbourne", Gauges.NONE, "Gillingbourne"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Holland Beck", Gauges.NONE, "HollandBeck"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Illie Town", Gauges.NONE, "IllieTown"));
            modelPageDetails.Layouts.Add(new LayoutDetails("K Street Yard", Gauges.NONE, "KStreetYard"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Lea Green Yard", Gauges.NONE, "LeaGreenYard"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Loch Tat", Gauges.NONE, "LochTat"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Low Moor", Gauges.NONE, "LowMoor"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Lynchwood Sidings", Gauges.NONE, "LynchwoodSidings"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Norton Folgate", Gauges.NONE, "NortonFolgate"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Oil DrumLane", Gauges.NONE, "OilDrumLane"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Penna Lane", Gauges.NONE, "PennaLane"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Sutherland Street", Gauges.NONE, "SutherlandStreet"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Titheridge Junction", Gauges.NONE, "TitheridgeJunction"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Weaver Hill", Gauges.NONE, "WeaverHill"));
            modelPageDetails.Layouts.Add(new LayoutDetails("West Street Station", Gauges.NONE, "WestStreetStation"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Zlata Vychod", Gauges.NONE, "ZlataVychod"));

            return modelPageDetails;
        }

        public static IModelEvent CreateLoughborough2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Loughborough Model Railway Exhibition",
                Descrption = "Loughborough Model Railway Exhibition",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-08-31 Loughborough model railway exhibition 2019",
                TripDate = new DateTime(2019, 08, 31),
                YouTubeLink = "https://www.youtube.com/embed/oFrYD7NMH-8",
                ImageFolder = "20190831-Loughborough",
                Title = "Loughborough Model Railway Exhibition 2019",
                ImagePreview = "P8315301-thumb.jpg"
            };
            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Loughborough", "Loughborough Model Railway Exhibition", });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateWoodthorpe2019()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Woodthorpe Model Railway Club",
                Descrption = "Woodthorpe Model Railway Club",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2019-10-26 Woodthorpe Model Railway Club",
                TripDate = new DateTime(2019, 10, 26),
                YouTubeLink = "https://www.youtube.com/embed/rXa8fywTtLg",
                ImageFolder = "20191026-Woodthorpe",
                Title = "Woodthorpe Model Railway Club 2019",
                ImagePreview = "PA266852-Woodthorpe-Model-thumb.jpg"
            };

            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Woodthorpe", "Woodthorpe Model Railway Club" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        private static IEnumerable<string> ModelEventKeywords()
        {
            return new string[] { "Model trains", "Model railway", "Exhibition", "Model", "Train show" };
        }

        public static IModelEvent CreateSyston2020()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Syston Model Railway Society",
                Descrption = "Leicester Model Railway Show. Sileby Community Centre, High ST, Sileby, Leicester. LE12 7RX",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2020-02-15 Syston Model Railway Society",
                TripDate = new DateTime(2020, 02, 16),
                YouTubeLink = "https://www.youtube.com/embed/i6PBrCMCTHg",
                ImageFolder = "20200215-Syston",
                Title = "Syston Model Railway Society 2020",
                ImagePreview = "P2157640-Newton-east-Syston-model-railway-thumb.JPG"
            };

            modelPageDetails.Layouts.Add(new LayoutDetails("Cumanavago", Gauges.O_Gauge));
            modelPageDetails.Layouts.Add(new LayoutDetails("Lisworth Bay", Gauges.N_Gauge, "01 Lisworth Bay"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Southgate DMU", Gauges.OO_Gauge, "02 Southgate Dmu"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Newtown East", Gauges.OO_Gauge, "03 Newton East"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Netherwood Sidings", Gauges.O_Gauge, "04 Netherwood Sidings"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Tudwich Road Sidings", Gauges.O_Gauge, "05 Tudwick Road Sidings"));
            modelPageDetails.Layouts.Add(new LayoutDetails(Layouts.Myton, Gauges.OO_Gauge, "06 Myton"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Power Station", Gauges.N_Gauge, "07 Power Station"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Heath Green", Gauges.OO_Gauge, "08 Heath Green"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Tennis Court Sidings", Gauges.N_Gauge, "09 Tennis Court Sidings"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Karolina Falls", Gauges.On30_Gauge, "10 Karolina Falls"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Harrowby Hill MPD", Gauges.OO_Gauge, "12 Harrowby Hill MPD"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Kozel Cement", Gauges.HO_Gauge, "13 Kozel Cement"));

            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Syston", "Syston Model Railway Society", "Leicester Model Railway Show" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateIlkeston2020()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Ilkeston (Woodside) Model Railway Club",
                Descrption = "Heanor Miners Welfare, Ilkeston Road, Heanor, Derbyshire DE75 7DT",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2020-02-23 Ilkeston (Woodside) Model Railway Club",
                TripDate = new DateTime(2020, 02, 23),
                EventAddress = "Heanor Miners Welfare, Ilkeston Road, Heanor, Derbyshire DE75 7DT",
                YouTubeLink = "https://www.youtube.com/embed/K-yUlJL_O6I",
                ImageFolder = "20200223-Ilkeston",
                Title = "Ilkeston (Woodside) Model Railway Club",
                ImagePreview = "P2237873-Avyn-A-Llyin-Ilkeston-thumb.JPG"
            };

            modelPageDetails.Layouts.Add(new LayoutDetails("Thomas the Tank Layout", Gauges.OO_Gauge));
            modelPageDetails.Layouts.Add(new LayoutDetails("Neuburg", Gauges.HO_Gauge, "02 Neuburg"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Avyn-A-Llyin", Gauges.OO9_Gauge, "03 Avyn-A-Llyin"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Rothbury", Gauges.OO_Gauge, "04 Rothbury"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Brookfield N (USA Based)", Gauges.NONE, "06 Brookfield N"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Poplar Sidings", Gauges.OO_Gauge, "07 Poplar Sidings"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Glenellen Castle", Gauges.N_Gauge, "08 Glenellen Castle"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Winter and Summer Hornby", Gauges.Dublo3Rail, "11 Winter and Summer Hornby Dublo 3 Rail"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Malcolm Hughes Vintage Trains", Gauges.Mixed_Gauge, "10 Malcolm Hughes Vintage Trains"));

            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Ilkeston", "Ilkeston (Woodside) Model Railway Club", "Ilkeston (Woodside) Model Railway", "Heanor Miners Welfare", "Heanor Model Railway" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }

        public static IModelEvent CreateLinclon2020March()
        {
            ModelEventPageDetails modelPageDetails = new ModelEventPageDetails
            {
                Name = "Newark - Lincoln Model Rail Club General Exhibition",
                Descrption = "Lincoln Model Rail Club General Exhibition",
                ImagesPath = @"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2020-02-29 NewarkLincolnModelRailClub",
                TripDate = new DateTime(2020, 02, 29),
                EventAddress = "Lady Eastwood Pavilion, Newark Showground, Drove Lane, Newark, Nottinghamshire NG24 2NY",
                EventDates = "Saturday 29th February & Sunday 1st March 2020",
                YouTubeLink = "https://www.youtube.com/embed/gHkPSd4i8_0",
                ImageFolder = "20200229-Newark",
                Title = "Lincoln Model Rail Club General Exhibition 2020",
                ImagePreview = "P2298149-Dorehill-sT-Lincoln-model-rail-club.Stephens-Lincoln-model-rail-club-thumb.JPG"
            };
            modelPageDetails.Layouts.Add(new LayoutDetails("Ambleton Vale", Gauges.N_Gauge, "Ambleton Vale"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Arnold Lane", Gauges.OO_Gauge, "Arnold Lane"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Barden", Gauges.O_Gauge, "Barden"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Bedford Road", Gauges.O_Gauge, "Bedford Road"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Blackgang", Gauges.NONE, "Blackgang"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Breydon", Gauges.OO_Gauge, "Breydon"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Caroline Concrete Works", Gauges.NONE, "Caroline Concrete Works"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Croft Mill Wharf", Gauges.O_Gauge, "Croft Mill Wharf"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Croft SPA", Gauges.N_Gauge, "Croft SPA"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Cumanavago", Gauges.OO_Gauge));
            modelPageDetails.Layouts.Add(new LayoutDetails("Dorehill ST. Stephens", Gauges.OO_Gauge, "Dorehill ST. Stephens"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Emsworth", Gauges.OO_Gauge, "Emsworth"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Glenellen Castle", Gauges.N_Gauge, "Glenellen Castle"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Hartley Poole", Gauges.N_Gauge, "Hartley Poole"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Hollington Quarry", Gauges.OO9_Gauge));
            modelPageDetails.Layouts.Add(new LayoutDetails("Kleine Rundfahrt", Gauges.N_Gauge_Continental, "Kleine Rundfahrt"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Kozel Cement", Gauges.HO_Gauge));
            modelPageDetails.Layouts.Add(new LayoutDetails("Norman Colliery", Gauges.O_Gauge, "Norman Colliery"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Northallerton", Gauges.N_Gauge, "Northallerton"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Obervaz", Gauges.H0mNarrowGauge, "Obervaz"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Roberts Road", Gauges.N_Gauge, "Roberts Road"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Salthaven Quay", Gauges.O_Gauge, "Salthaven Quay"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Shaken & Not Stirred", Gauges.NONE));
            modelPageDetails.Layouts.Add(new LayoutDetails("Spilsby", Gauges.NONE, "Spilsby"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Stamford East", Gauges.N_Gauge, "Stamford East"));
            modelPageDetails.Layouts.Add(new LayoutDetails("The Power Station", Gauges.N_Gauge, "The Power Station"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Thorncliffe", Gauges.OO_Gauge, "Thorncliffe"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Welby Lane", Gauges.NONE, "Welby Lane"));
            modelPageDetails.Layouts.Add(new LayoutDetails("Worlds Way", Gauges.OO_Gauge, "Worlds Way"));
            modelPageDetails.Layouts.Add(new LayoutDetails(Layouts.Myton, Gauges.OO_Gauge, "Myton"));

            modelPageDetails.Keywords.AddRange(ModelEventKeywords());
            modelPageDetails.Keywords.AddRange(new string[] { "Linclon", "L&DMRC", "Lincoln Model Rail Club", "Newark Showground", "General Exhibition" });
            modelPageDetails.MetaDetails = modelPageDetails.Descrption;
            return modelPageDetails;
        }
    }
}
