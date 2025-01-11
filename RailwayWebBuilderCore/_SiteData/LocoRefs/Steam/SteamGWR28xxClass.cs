using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamGWR28xxClass : SteamClassBase
    {
        public SteamGWR28xxClass()
        {
            ClassName = "GWR 28xx Class Pannier";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "";
            Paragraph2 = "";
            Paragraph3 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("2807"),
                });
        }
    }
}