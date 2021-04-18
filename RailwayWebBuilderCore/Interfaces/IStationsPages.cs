using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface IStationsPages : IPageDetails
    {
        StationLocationsBase StationLocations { get; }

        string HilightImage { get; }
    }
}