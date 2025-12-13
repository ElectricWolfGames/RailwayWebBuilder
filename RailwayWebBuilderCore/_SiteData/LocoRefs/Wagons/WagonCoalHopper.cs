using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonCoalHopper : WagonsClassBase
{
    public WagonCoalHopper()
    {
        ClassName = "Coal Hopper";
        StockType = StockTypes.Wagon;

        Paragraph1 = "Head Wrightson 1957";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B425356" ),
            });
    }
}