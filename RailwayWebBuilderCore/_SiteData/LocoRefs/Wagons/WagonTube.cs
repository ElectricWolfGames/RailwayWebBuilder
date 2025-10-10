using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonTube : WagonsClassBase
{
    public WagonTube()
    {
        ClassName = "Tube";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("E301588" ),
            new LocoDetails("B732357" ),
            });
    }
}