using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamGWR5700 : SteamClassBase
    {
        public SteamGWR5700()
        {
            ClassName = "GWR5700 Pannier";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "";
            Paragraph2 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("7714"),
                });
        }
    }
}