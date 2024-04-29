using RailwayWebBuilderCore.Data; using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.StationLocations
{
    public class RushcliffeHaltGCR : StationLocationsBase
    {
        public RushcliffeHaltGCR()
        {
            Name = "Rushcliffe Halt, East Leake, Great Central Railway";
            LatitudeLongitude = new LatitudeLongitude(52.84383440266633, -1.1821199020700344);
            Address = "Gotham Road, East Leake, Nottinghamshire";
            PostCode = string.Empty;
            ShortName = "Rushcliffe Halt";
        }
    }
}