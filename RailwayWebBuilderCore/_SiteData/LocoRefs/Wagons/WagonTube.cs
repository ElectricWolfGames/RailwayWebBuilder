using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonTube : WagonsClassBase
{
    public WagonTube()
    {
        ClassName = "Tube";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "Darlington & Derby Works";
        BuildDate = "1954-1961";
        Diagram = "1/448 (TOPS STV, later ZAV/ZDB/ZDV/ZDW/ZDX/ZGV/ZSW)";
        Length = "32ft";
        Wheelbase = "18ft 6in";
        LoadCapacity = "22T";
        BrakeType = "Vacuum-fitted (early examples unfitted)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("E301588" ),
            new LocoDetails("B732357" ),
            });
    }
}