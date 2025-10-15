using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamClassA3 : SteamClassBase
{
#warning Need to add description Class 99
    public SteamClassA3()
    {
        ClassName = "Class A3";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("60103", "Flying Scotsman"),
            });
    }
}