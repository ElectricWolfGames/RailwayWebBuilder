using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonPipe : WagonsClassBase
{
    public WagonPipe()
    {
        ClassName = "Pipe";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B740654" ),
            });
    }
}