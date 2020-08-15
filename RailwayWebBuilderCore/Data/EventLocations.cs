using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore.Data
{
    abstract public class EventLocationsBase : ILocations
    {
        public EventLocationsBase()
        {
            LocationType = LocationTypes.ModelRailway;
        }

        public string Address { get; set; }
        public LatitudeLongitude LatitudeLongitude { get; set; }
        public LocationTypes LocationType { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
    }
}
