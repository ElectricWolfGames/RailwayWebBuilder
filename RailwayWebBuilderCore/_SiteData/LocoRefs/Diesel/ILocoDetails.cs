using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public interface ILocoDetails
    {
        List<string> Ignore { get; set; }
        string Name { get; set; }
        string Number { get; set; }
    }
}