using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamGWR2900 : SteamClassBase
    {
        public SteamGWR2900()
        {
            ClassName = "GWR 2900 Saint";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("2999", "Lady of Legend"),
                });
        }
    }
}