using RailwayWebBuilder.Interfaces;

namespace RailwayWebBuilder.Data
{
    abstract public class EventLocationsBase : ILocations
    {
        public string Address { get; set; }
        public string PostCode { get; set; }
        public LatitudeLongitude LatitudeLongitude { get; set; }
        public string Name { get; set; }
    }
}
