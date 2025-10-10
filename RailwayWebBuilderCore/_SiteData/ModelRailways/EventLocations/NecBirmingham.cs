using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations;

public class NecBirmingham : EventLocationsBase
{
    public NecBirmingham()
    {
        Name = "Nec Birmingham";
        LatitudeLongitude = new LatitudeLongitude(52.4527218612038, -1.7204387809645283);
        Address = "Nec Birmingham, Hall 12, Pendigo Way, Birmingham, West Midlands B40 1NT";
        PostCode = "B40 1NT";
    }
}