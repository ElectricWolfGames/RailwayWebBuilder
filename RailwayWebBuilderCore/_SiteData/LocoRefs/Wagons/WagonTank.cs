using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonTank_Others : WagonsClassBase
{
    public WagonTank_Others()
    {
        ClassName = "Tank";
        StockType = StockTypes.Wagon;// Tank
        Paragraph1 = "";
        Paragraph2 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("5209" ),
            new LocoDetails("6071" ),
            new LocoDetails("6090" ),
            new LocoDetails("6581" ),
            new LocoDetails("A4531" ),
            new LocoDetails("B749677" ),
            new LocoDetails("DB998926" ),
            new LocoDetails("VTG60874" ),
            new LocoDetails("VTG60879" ),
            });
    }
}