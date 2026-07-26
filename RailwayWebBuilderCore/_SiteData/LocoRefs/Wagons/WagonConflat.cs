using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonConflat : WagonsClassBase
{
    public WagonConflat()
    {
        ClassName = "Conflat";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        BuildDate = "1955-1956";
        Diagram = "1/067 (TOPS FAV)";
        Wheelbase = "10ft";
        TareWeight = "13T";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B505313" ),
            new LocoDetails("B507489" ),
            });
    }
}