using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamBRStandard2 : SteamClassBase
    {
        public SteamBRStandard2()
        {
            ClassName = "BR Standard 2";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "The BR Standard Class 2 2-6-0 is a class of steam locomotive, one of the British Railways Standard classes of the 1950s. They were physically the smallest of the Standard classes";
            Paragraph2 = "65 were built";

            Keywords.Add("BR Standard Class 2");
            Keywords.Add("class 2");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("78018"),
                new LocoDetails("78019"),
                });
        }
    }
}