using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonTankA : WagonsClassBase
{
    public WagonTankA()
    {
        ClassName = "Tank A 20T";
        StockType = StockTypes.Wagon;
        Paragraph1 = "Tank, 20T ";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("A4513" ),
            new LocoDetails("A6581" ),
            });
    }
}