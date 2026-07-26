using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonIronOreHopper : WagonsClassBase
{
    public WagonIronOreHopper()
    {
        ClassName = "Iron Ore Hopper";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        BuildDate = "1955-1957";
        Diagram = "1/163 (TOPS HJO/HIO, vacuum-fitted conversions HJV/HKV)";
        LoadCapacity = "25.5T";
        BrakeType = "Unfitted (originally)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B439708" ),
            });
    }
}