using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonHighfit : WagonsClassBase
{
    public WagonHighfit()
    {
        ClassName = "Highfit";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "BR Shildon";
        Diagram = "1/041 (TOPS OHV)";
        Wheelbase = "10ft";
        LoadCapacity = "13T";
        BrakeType = "Vacuum-braked (Morton 4-shoe)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("E312422" ),
            new LocoDetails("B477060" ),
            });
    }
}