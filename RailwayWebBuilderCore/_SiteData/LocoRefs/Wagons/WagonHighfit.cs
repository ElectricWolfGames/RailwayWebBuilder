using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonHighfit : WagonsClassBase
{
    public WagonHighfit()
    {
        ClassName = "Highfit";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("E312422" ),
            new LocoDetails("B477060" ),
            });
    }
}