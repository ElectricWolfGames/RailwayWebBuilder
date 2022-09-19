using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Stations.StationLocations
{
    public class Mainline_LoughboroughAddress : StationLocationsBase
    {
        public Mainline_LoughboroughAddress()
        {
            Name = "Mainline Loughborough Station (East Midlands Railway)";
            LatitudeLongitude = new LatitudeLongitude(52.779213, -1.19606495);
            Address = "Station Blvd";
            PostCode = "LE11 1EX";
            ShortName = "Loughborough Station";
        }
    }
}