using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public class StationsHeader : IHeader
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }

        public StationsHeader()
        {
            Title = "Stations";
            Keywords = new List<string>
            {
                "Stations",
            };
            MetaDetails = "Railway Stations";
        }
    }
}
