using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWRPannierTank : SteamClassBase
{
    public SteamGWRPannierTank()
    {
        ClassName = "GWR Pannier";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";
        Paragraph2 = "";
        Paragraph3 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1369"),
            });
    }
}