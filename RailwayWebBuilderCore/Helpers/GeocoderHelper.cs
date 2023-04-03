using eWolfCommon.Helpers;
using Geocoder;
using Microsoft.VisualStudio.Services.Common;
using RailwayWebBuilderCore.Attributes;
using RailwayWebBuilderCore.Data;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Helpers
{
    public static class ItemHelper
    {
        public static (string, Gauges) GetEnumDescription(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionGaugeAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionGaugeAttribute), false) as DescriptionGaugeAttribute[];

            if (attributes != null && attributes.Any())
            {
                return (attributes.First().Description, attributes.First().Gauge);
            }

            return (value.ToString(), Gauges.NONE);
        }
    }

    public class GeocoderHelper
    {
        private static GeocoderHelper _instance;
        private readonly GeocoderStore _geocoderStore;
        private readonly GeocodeService _geocodeService;

        public GeocoderHelper()
        {
            _geocoderStore = ReadWriteFileHelper.ReadFromXmlFile<GeocoderStore>(Filename);

            _geocodeService = new GeocodeService();
        }

        public static GeocoderHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GeocoderHelper();
                return _instance;
            }
        }

        private string Filename
        {
            get { return @"Store.xml"; }
        }

        public Location GetLatitudeAndLongitude(string locationName)
        {
            var geocoder = new GeocodeService();

            // geocode the location of the White House
            return geocoder.GeocodeLocation(locationName);
        }

        public string GetLatitudeAndLongitudeString(string locationName, bool cacheOnly = true)
        {
            // check to see if that name is a in the cahce already.
            string locat = string.Empty;
            /*if (_geocoderStore.TryGetLocation(locationName, out locat))
            {
                return locat;
            }
            if (cacheOnly)
                return locat;
            */
            Location loc = new Location
            {
                Latitude = 20,
                Longitude = 20
            };
            try
            {
                // geocode the location of the White House
                loc = _geocodeService.GeocodeLocation(locationName);
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Failed to parse location for " + locationName);
                return string.Empty;
            }

            string str = $"lat: {loc.Latitude}, lng: {loc.Longitude}";
            string str2 = "{" + str + "}";

            _geocoderStore.Add(locationName, str2);
            Save();
            return str2;
        }

        private void Save()
        {
            ReadWriteFileHelper.WriteToXmlFile<GeocoderStore>(Filename, _geocoderStore, false);
        }
    }

    [Serializable]
    public class GeocoderStore
    {
        private SerializableDictionary<string, string> _cache = new SerializableDictionary<string, string>();

        public SerializableDictionary<string, string> Cache { get => _cache; set => _cache = value; }

        internal void Add(string locatonName, string loc)
        {
            _cache.Add(locatonName, loc);
        }

        internal bool TryGetLocation(string locationName, out string loc)
        {
            return _cache.TryGetValue(locationName, out loc);
        }
    }
}