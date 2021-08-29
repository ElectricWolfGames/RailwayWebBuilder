using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILocations
    {
        string Address { get; set; }
        LatitudeLongitude LatitudeLongitude { get; set; }
        LocationTypes LocationType { get; set; }
        string Name { get; set; }
        string PostCode { get; set; }
        string ShortName { get; set; }
    }
}