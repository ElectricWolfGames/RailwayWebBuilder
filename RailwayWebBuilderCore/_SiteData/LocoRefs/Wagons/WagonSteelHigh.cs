using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonSteelHigh : WagonsClassBase
{
    public WagonSteelHigh()
    {
        ClassName = "Steel High";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Diagram = "TOPS OHV/OHB";
        LoadCapacity = "13T";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("ADE280364" ),
            new LocoDetails("E281882" ),
            });
    }
}