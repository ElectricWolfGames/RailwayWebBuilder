using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class Wagon_Medfit : WagonsClassBase
{
    public Wagon_Medfit()
    {
        ClassName = "Medfit";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Diagram = "1/019 (steel-bodied)";
        LoadCapacity = "13T";
        BrakeType = "Vacuum-braked when new (often later removed)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B458484" ),
            new LocoDetails("B461074" ),
            new LocoDetails("M477031" ),
            });
    }
}