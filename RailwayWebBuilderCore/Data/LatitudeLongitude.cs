namespace RailwayWebBuilder.Data
{
    public class LatitudeLongitude
    {
        public LatitudeLongitude(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }

        public string Location
        {
            get
            {
                return $"lat: {Latitude}, lng: {Longitude}";
            }
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
