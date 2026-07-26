using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonMackerel17T : WagonsClassBase
{
    public WagonMackerel17T()
    {
        ClassName = "Mackerel 17 Ton";
        StockType = StockTypes.Wagon;

        Paragraph1 = "Mackerel 17 ton Ballast Hopper Wagon";
        Builder = "Metro-Cammell";
        BuildDate = "1951";
        Diagram = "1/583 (TOPS ZMV)";
        Length = "21ft 8in";
        TareWeight = "9T 1cwt";
        LoadCapacity = "17T";
        BrakeType = "Vacuum-braked";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("DB992358" ),
            });
    }
}