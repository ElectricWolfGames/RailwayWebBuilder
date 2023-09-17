using eWolfBootstrap.Interfaces;
using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface IStationsPages
    {
        string HilightImage { get; }
        StationLocationsBase StationLocations { get; }

        public string HtmlFileName { get; }
    }
}