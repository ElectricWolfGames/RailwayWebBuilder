using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonPalvanShock : WagonsClassBase
{
    public WagonPalvanShock()
    {
        ClassName = "Palvan Shock";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        BuildDate = "1961";
        Diagram = "219 (TOPS VRV)";
        BrakeType = "Vacuum-braked (BR clasp)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B855667" ),
            });
    }
}