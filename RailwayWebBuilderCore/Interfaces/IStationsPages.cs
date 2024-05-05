using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface IStationsPages
    {
        string HilightImage { get; }
        public string HtmlFileName { get; }
        StationLocationsBase StationLocations { get; }
    }
}