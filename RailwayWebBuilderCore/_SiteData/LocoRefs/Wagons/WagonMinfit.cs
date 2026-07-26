using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonMinfit : WagonsClassBase
{
    public WagonMinfit()
    {
        ClassName = "Minfit";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Diagram = "TOPS MCO/MCV (later MXV)";
        LoadCapacity = "16T";
        BrakeType = "Vacuum-braked (8-shoe clasp tread brake)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B550356" ),
            });
    }
}