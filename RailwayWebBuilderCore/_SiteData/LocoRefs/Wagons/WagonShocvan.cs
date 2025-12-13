using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonShocvan : WagonsClassBase
{
    public WagonShocvan()
    {
        ClassName = "Shocvan";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B850498" ),
            new LocoDetails("B852838" ),
            new LocoDetails("B854097" ),
            });
    }
}