using RailwayWebBuilder.Data;

namespace RailwayWebBuilder.Interfaces
{
    public interface ILocations
    {
        string Name { get; set; }
        LatitudeLongitude LatitudeLongitude { get; set; }
        string Address { get; set; }
        string PostCode { get; set; }
    }
}
