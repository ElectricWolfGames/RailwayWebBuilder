using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamColinMcAndrewCoy : SteamClassBase
{
    public SteamColinMcAndrewCoy()
    {
        ClassName = "ColinMcAndrew&Coy";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";
        Paragraph2 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("ColinMcAndrew&Coy"),
            });
    }
}