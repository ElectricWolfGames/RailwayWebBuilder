using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonTank_TTB : WagonsClassBase
{
    public WagonTank_TTB()
    {
        ClassName = "Tank TTB";
        StockType = StockTypes.Wagon;// Tank
        Paragraph1 = "Charles Roberts & Co 1965, Tank,  TTB";
        Paragraph2 = "Diagram number: 6/138 – TT020C";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1408" ),
            });
    }
}