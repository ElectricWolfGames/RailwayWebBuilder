using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

#warning Need to add description LMSStanierMogul

public class LMSStanierMogul : SteamClassBase
{
    public LMSStanierMogul()
    {
        ClassName = "Stanier Mogul";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";

        Keywords.Add("Stanier Mogul");
        Keywords.Add("LMS");
        Keywords.Add("13268");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("13268"),
            });
    }
}