using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

#warning Need to add description WebbCoalTank

public class WebbCoalTank : SteamClassBase
{
    public WebbCoalTank()
    {
        ClassName = "Webb Coal Tank (LNWR)";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";

        Keywords.Add("Webb Coal Tank");
        Keywords.Add("1054");
        Keywords.Add("LNWR");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1054"),
            });
    }
}