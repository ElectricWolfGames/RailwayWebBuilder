using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamLNERJ27 : SteamClassBase
    {
        public SteamLNERJ27()
        {
            ClassName = "LNER J27, NER Class P3";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("65894"),
                });
        }
    }
}