using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class JubileeClass : SteamClassBase
{
#warning Need to add description JubileeClass

    public JubileeClass()
    {
        ClassName = "Jubilee Class";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "";

        Keywords.Add("LMS");
        Keywords.Add("45596");
        Keywords.Add("Bahamas");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("45596", "Bahamas"),
            });
    }
}