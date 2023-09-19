using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.EventLocations
{
    public class RootsatThorpeFarm : EventLocationsBase
    {
        public RootsatThorpeFarm()
        {
            Name = "Roots at Thorpe Farm";
            LatitudeLongitude = new LatitudeLongitude(52.6765225, -1.06075956);
            Address = "Roots at Thorpe Farm, Barkby Thorpe, Leicester, Leicestershire LE7 3QE";
            PostCode = "LE7 3QE";
        }
    }

    public class TheSummitCentreKirkby : EventLocationsBase
    {
        public TheSummitCentreKirkby()
        {
            Name = "The Summit Centre, Kirkby";
            LatitudeLongitude = new LatitudeLongitude(53.104722, -1.242296);
            Address = "The Summit Centre, Pavilion Road Off Lowmoor Road, Kirkby-In-Ashfield, Nottinghamshire, NG17 7LL";
            PostCode = "NG17 7LL";
        }
    }
}