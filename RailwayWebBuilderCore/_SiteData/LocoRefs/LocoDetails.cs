using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

namespace RailwayWebBuilderCore._SiteData.LocoRefs
{
    public class LocoDetails : ILocoDetails
    {
        public LocoDetails(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public LocoDetails(string number)
        {
            Number = number;
        }

        public string Name { get; set; }
        public string Number { get; set; }
    }
}