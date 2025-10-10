using RailwayWebBuilderCore.Enums;
using static System.Net.WebRequestMethods;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR2900 : SteamClassBase
{
    public SteamGWR2900()
    {
        ClassName = "GWR 2900 Saint";
        StockType = StockTypes.SteamLoco;

        WikiLink = "https://en.wikipedia.org/wiki/GWR_2900_Class";

        Paragraph1 = "";
        Paragraph2 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("2999", "Lady of Legend"),
            });
    }
}