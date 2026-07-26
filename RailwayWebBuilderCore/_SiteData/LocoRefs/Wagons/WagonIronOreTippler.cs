using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonIronOreTippler : WagonsClassBase
{
    public WagonIronOreTippler()
    {
        ClassName = "Iron Ore Tippler";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Diagram = "TOPS MSO/MSV (also MCO/MCV, MXV)";
        LoadCapacity = "21T (later 27T)";
        BrakeType = "Unfitted (majority; some vacuum-fitted conversions)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B385782" ),
            });
    }
}