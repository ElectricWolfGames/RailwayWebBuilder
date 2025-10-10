namespace RailwayWebBuilderCore.Data;

public class LatitudeLongitude
{
    public LatitudeLongitude(double lat, double lon)
    {
        Latitude = lat;
        Longitude = lon;
    }

    public double Latitude { get; set; }

    public string Location
    {
        get
        {
            return $"lat: {Latitude}, lng: {Longitude}";
        }
    }

    public double Longitude { get; set; }
}