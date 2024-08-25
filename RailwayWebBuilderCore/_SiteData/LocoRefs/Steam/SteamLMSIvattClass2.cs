using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamLMSIvattClass2 : SteamClassBase
    {
        public SteamLMSIvattClass2()
        {
            ClassName = "LMS Ivatt Class 2 2-6-0";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "";
            Keywords.Add("H. G. Ivatt");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("46521"),
                });
        }
    }
}