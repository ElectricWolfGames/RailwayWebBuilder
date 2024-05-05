using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData.LocoRefs
{
    public class LocoDetails : ILocoDetails
    {
        public LocoDetails(string number, string name, string ignore = "")
        {
            Number = number;
            Name = name;
            Ignore.AddRange(ignore.Split(","));
        }

        public LocoDetails(string number)
        {
            Number = number;
        }

        public List<string> Ignore { get; set; } = new List<string>();
        public string Name { get; set; }
        public string Number { get; set; }
    }
}