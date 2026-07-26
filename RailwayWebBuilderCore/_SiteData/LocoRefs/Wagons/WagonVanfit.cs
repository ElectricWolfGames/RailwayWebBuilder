using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonVanfit : WagonsClassBase
{
    public WagonVanfit()
    {
        ClassName = "Vanfit";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        BuildDate = "1951-1958";
        Diagram = "1/208 (TOPS VVV)";
        Wheelbase = "10ft";
        LoadCapacity = "12T";
        BrakeType = "Vacuum-braked (Morton 4-shoe, later BR 8-shoe clasp)";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("M500954" ),
            new LocoDetails("B762855" ),
            new LocoDetails("B763305" ),
            new LocoDetails("B765272" ),
            new LocoDetails("B777171" ),
            new LocoDetails("B777728" ),
            new LocoDetails("B779978" ),
            new LocoDetails("B780282" ),
            new LocoDetails("B786181" ),
            new LocoDetails("B786348" ),
            });
    }
}