using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class DirectorClass : SteamClassBase
{
#warning Need to add description DirectorClass

    public DirectorClass()
    {
        ClassName = "Director Class";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";

        Keywords.Add("GCR 506");
        Keywords.Add("Butler Henderson");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("GCR506", "Butler Henderson"),
            });
    }
}