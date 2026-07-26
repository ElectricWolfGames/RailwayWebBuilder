using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonBrakevan20T : WagonsClassBase
{
    public WagonBrakevan20T()
    {
        ClassName = "Brakevan 20T";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "Faverdale Works, Darlington";
        Diagram = "1/506 (TOPS CAO/CAP/CAR)";
        Length = "27ft 6in";
        Wheelbase = "16ft";
        TareWeight = "20T";
        BrakeType = "Unfitted";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B954546" ),
            new LocoDetails("B950690" ),
            });
    }
}