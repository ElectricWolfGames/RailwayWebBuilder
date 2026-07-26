using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonSingleBolster : WagonsClassBase
{
    public WagonSingleBolster()
    {
        ClassName = "Single Bolster";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Diagram = "1/402";
        Wheelbase = "10ft";
        BrakeType = "Unfitted (RCH standard)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B916549" ),
            });
    }
}