using RailwayWebBuilder.Interfaces;

namespace RailwayWebBuilder.Data
{
    public class EventLocations : ILocations
    {
        public string EventAddress { get; set; }
        public string EventPostCode { get; set; }
        public LatitudeLongitude LatitudeLongitude { get; set; }
        public string Name { get; set; }
    }
}
