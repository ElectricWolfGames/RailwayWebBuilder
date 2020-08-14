using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public class LayoutDetails
    {
        public LayoutDetails(string name, Gauges gauge)
        {
            Name = name;
            Gauge = gauge;
        }

        public LayoutDetails(string name, Gauges gauge, string path)
        {
            Name = name;
            Gauge = gauge;
            Path = path;
        }

        public Gauges Gauge { get; set; }

        public string IDName
        {
            get
            {
                return Name.Replace(" ", "-");
            }
        }

        public List<string> ImagePaths { get; set; } = new List<string>();
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class LayoutNames
    {
        public const string Myton = "Myton";
    }
}
