using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamGWR2884 : SteamClassBase
    {
        public SteamGWR2884()
        {
            ClassName = "GWR 2884";
            StockType = StockTypes.SteamLoco;

            Paragraph1 = "They were designed for heavy freight work and were a development of the earlier 2800 Class. " +
                     "The 2884s differed from the original engines in a number of respects, " +
                     "the most obvious being that a more modern Collett side window cab was provided and that they were built with outside steam pipes. " +
                     "83 of the 2884 class were built between 1938 and 1941. Those built during the war did not have the side window to the cab, " +
                     "and the side window on the others was plated over. This was to reduce glare, as a precaution against enemy air attacks. " +
                     "The windows were reinstated after the war.";
            Paragraph2 = "3802 was built in 1938 at the GWR’s Swindon Works. " +
                "The locomotive was withdrawn from Bristol Barrow Road depot in August 1965 and reached Barry Scrapyard in October. " +
                "In Summer 2010 the locomotive fleet was ‘one short’ for the summer peak service, resulting in the hire of 3802 from Llangollen";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("3802"),
                });
        }
    }
}