﻿using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore.Data
{
    abstract public class StationLocationsBase : ILocations
    {
        public StationLocationsBase()
        {
            LocationType = LocationTypes.Startion;
        }

        public string Address { get; set; }
        public LatitudeLongitude LatitudeLongitude { get; set; }
        public LocationTypes LocationType { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string PostCode { get; set; }
    }
}