using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonShocvan : WagonsClassBase
{
    public WagonShocvan()
    {
        ClassName = "Shocvan";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "BR Darlington / Ashford";
        BuildDate = "1951-1959";
        Diagram = "1/209, 1/218, 1/220 (TOPS VSV)";
        Wheelbase = "10ft";
        LoadCapacity = "12T";
        BrakeType = "Vacuum-braked (Morton 4-shoe, later BR 8-shoe clasp)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B850498" ),
            new LocoDetails("B852838" ),
            new LocoDetails("B854097" ),
            });
    }
}