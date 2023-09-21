using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore._SiteData.StationLocations
{
    public class RothleyStationGCR : StationLocationsBase
    {
        public RothleyStationGCR()
        {
            Name = "Rothley Station, Great Central Railway";
            LatitudeLongitude = new LatitudeLongitude(52.70459550090345, -1.1598164015656793);
            Address = "Station Rd, Leicester LE7 7LA";
            PostCode = "LE7 7LA";
            ShortName = "Rothley Station";
        }
    }
}