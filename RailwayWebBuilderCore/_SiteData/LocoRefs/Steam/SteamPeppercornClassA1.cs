using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamPeppercornClassA1 : SteamClassBase
    {
        public SteamPeppercornClassA1()
        {
            ClassName = "Peppercorn Class A1";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "LNER Peppercorn Class A1 60163 Tornado is a 4-6-2 steam locomotive built by the A1 Steam Locomotive Trust." +
                "Completed in 2008 at the cost of around £3 million, it is the first newly built main line steam locomotive in the UK since Evening Star in 1960." +
                "It is the only example of an LNER Peppercorn Class A1 locomotive in existence, the entirety of the original production batch having been scrapped." +
                "60163 is named after the Panavia Tornado, a combat aircraft flown by the Royal Air Force. In 2017," +
                "Tornado became the first steam locomotive to officially reach 100 mph on British tracks for over 50 years.";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("60163", "Tornado"),
                });
        }
    }
}