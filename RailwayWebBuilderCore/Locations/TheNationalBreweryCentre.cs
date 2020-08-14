using RailwayWebBuilder.Data;
using RailwayWebBuilder.Interfaces;

namespace RailwayWebBuilderCore.Locations
{
    public class TheNationalBreweryCentre : ILocations
    {
        public string Name { get; set; } = "The National Brewery Centre";
        public LatitudeLongitude LatitudeLongitude { get; set; } = new LatitudeLongitude(52.807752, -1.631799);
        public string EventAddress { get; set; } = "The National Brewery Centre, Horninglow Street, Burton Upon Trent, DE14 1NG";
        public string EventPostCode { get; set; } = "DE14 1NG";
    }
}
