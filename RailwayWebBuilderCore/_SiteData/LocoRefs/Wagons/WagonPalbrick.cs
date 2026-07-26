using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonPalbrick : WagonsClassBase
{
    public WagonPalbrick()
    {
        ClassName = "Palbrick";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        BuildDate = "1957-1959";
        Diagram = "1/020 (Palbrick A), 1/024 (Palbrick B), 1/026 (Palbrick B/C)";
        LoadCapacity = "13T (Palbrick A), 16T (Palbrick B/C)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B462709" ),
            });
    }
}