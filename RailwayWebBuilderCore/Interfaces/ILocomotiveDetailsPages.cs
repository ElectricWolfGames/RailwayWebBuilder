using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILocomotiveDetailsPages : IRailwayPageBuilder, IPageDetails
    {
    }

    public interface IStationsPages : IPageDetails
    {
        StationLocationsBase StationLocations { get; }

        string HilightImage { get; }
    }
}