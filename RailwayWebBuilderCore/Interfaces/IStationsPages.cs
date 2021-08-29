using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface IStationsPages : IPageDetails
    {
        string HilightImage { get; }
        StationLocationsBase StationLocations { get; }
    }
}