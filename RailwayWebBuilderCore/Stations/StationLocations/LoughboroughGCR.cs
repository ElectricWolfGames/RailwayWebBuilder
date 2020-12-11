using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Stations.StationLocations
{
    public class LoughboroughGCR : StationLocationsBase
    {
        public LoughboroughGCR()
        {
            Name = "Loughborough, Great Central Railway";
            LatitudeLongitude = new LatitudeLongitude(52.769585, -1.196141);
            Address = "Loughborough Central Station, LE11 1RW";
            PostCode = "LE11 1RW";
            ShortName = "Loughborough Station";
        }
    }
}