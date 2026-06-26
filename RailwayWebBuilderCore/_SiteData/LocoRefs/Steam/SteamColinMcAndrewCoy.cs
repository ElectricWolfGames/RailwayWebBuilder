using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamColinMcAndrewCoy : SteamClassBase
{
    public SteamColinMcAndrewCoy()
    {
        ClassName = "ColinMcAndrew&Coy";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "Colin McAndrew & Coy was a Victorian-era engineering contractor and locomotive operator. " +
            "Locomotives carrying this builder's or owner's plate are typically contractor or industrial engines used on civil engineering projects, " +
            "quarry work, or light railway construction during the 19th century.";

        Keywords.Add("Colin McAndrew");
        Keywords.Add("industrial locomotive");
        Keywords.Add("contractor locomotive");
        Keywords.Add("Victorian");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("ColinMcAndrew&Coy"),
            });
    }
}