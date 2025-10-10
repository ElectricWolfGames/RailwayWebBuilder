using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamBattleofBritain : SteamClassBase
{
    public SteamBattleofBritain()
    {
        ClassName = "Battle of Britain";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The SR West Country and Battle of Britain classes, collectively known as Light Pacifics or informally as Spam Cans, " +
            "are air-smoothed 4-6-2 Pacific steam locomotives designed for the Southern Railway by its Chief Mechanical Engineer Oliver Bulleid. " +
            "Incorporating a number of new developments in British steam locomotive technology, they were amongst the first British designs to use " +
            "welding in the construction process, and to use steel fireboxes, which meant that components could be more easily constructed under wartime " +
            "austerity and post-war economy";

        Keywords.Add("34072, Battle of Britain, 257 Squadron");
        Keywords.Add("257 Squadron");
        Keywords.Add("34072");
        Keywords.Add("Battle of Britain");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("34072", "257 Squadron"),
            });
    }
}