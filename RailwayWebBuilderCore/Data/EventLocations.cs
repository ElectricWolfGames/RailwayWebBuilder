using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore.Data
{
    public abstract class EventLocationsBase : ILocations
    {
        public EventLocationsBase()
        {
            LocationType = LocationTypes.ModelRailway;
        }

        public string Address { get; set; }
        public LatitudeLongitude LatitudeLongitude { get; set; }
        public LocationTypes LocationType { get; set; }
        public string Name { get; set; }

        public string PostCode { get; set; }

        public string ShortName
        {
            get
            {
                return Name;
            }
            set { }
        }
    }
}