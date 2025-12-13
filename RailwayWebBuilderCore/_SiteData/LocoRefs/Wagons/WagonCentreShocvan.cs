using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonCentreShocvan : WagonsClassBase
{
    public WagonCentreShocvan()
    {
        ClassName = "Centre Shocvan";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B854782" ),
            });
    }
}