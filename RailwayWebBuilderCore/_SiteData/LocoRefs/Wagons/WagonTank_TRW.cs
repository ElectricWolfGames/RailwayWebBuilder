using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonTank_TRW : WagonsClassBase
{
    public WagonTank_TRW()
    {
        ClassName = "Tank TRW";
        StockType = StockTypes.Wagon;
        Paragraph1 = "Charles Roberts & Co 1958, Tank, TRW";
        Paragraph2 = "Diagram number: 6/002";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("3436" ),
        });
    }
}

public class WagonTank_TRWa : WagonsClassBase
{
    public WagonTank_TRWa()
    {
        ClassName = "Tank TRW";
        StockType = StockTypes.Wagon;
        Paragraph1 = "Hurst Nelson 1959, Tank, TRW";
        Paragraph2 = "Diagram number: 6/668";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("3711" ),
            new LocoDetails("3777" ),
        });
    }
}