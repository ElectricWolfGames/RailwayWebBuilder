using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonFerryTank : WagonsClassBase
{
    public WagonFerryTank()
    {
        ClassName = "Ferry Tank";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("500817" ),
            });
    }
}