using RailwayWebBuilder.Data;

namespace RailwayWebBuilder.Interfaces
{
    public interface ILocations
    {
        string Name { get; set; }
        LatitudeLongitude LatitudeLongitude { get; set; }
        string EventAddress { get; set; }
        string EventPostCode { get; set; }
    }
}
