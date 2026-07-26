using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonShochood : WagonsClassBase
{
    public WagonShochood()
    {
        ClassName = "Shochood";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "BR Derby";
        BuildDate = "1963";
        Diagram = "1/058 (TOPS OUV)";
        Wheelbase = "12ft";
        LoadCapacity = "20T";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B726344" ),
            });
    }
}