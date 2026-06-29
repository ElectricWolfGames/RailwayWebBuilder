using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR2884 : SteamClassBase
{
    public SteamGWR2884()
    {
        ClassName = "GWR 2884";
        StockType = StockTypes.SteamLoco;

        Designer = "Charles Collett (development of Churchward 28xx)";
        Builder = "GWR Swindon Works";
        BuildDate = "1938–1942";
        TotalProduced = 83;
        WhyteNotation = "2-8-0";
        Cylinders = "2 × 18½ in × 30 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "4 ft 7½ in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "76 tons 6 cwt";
        TenderWeight = "40 tons 0 cwt";
        Length = "58 ft 9 in";
        MaxSpeed = "60 mph";
        TractiveEffort = "35,380 lbf";

        Paragraph1 = "They were designed for heavy freight work and were a development of the earlier 2800 Class. " +
                 "The 2884s differed from the original engines in a number of respects, " +
                 "the most obvious being that a more modern Collett side window cab was provided and that they were built with outside steam pipes. " +
                 "83 of the 2884 class were built between 1938 and 1941. Those built during the war did not have the side window to the cab, " +
                 "and the side window on the others was plated over. This was to reduce glare, as a precaution against enemy air attacks. " +
                 "The windows were reinstated after the war.";
        Paragraph2 = "3802 was built in 1938 at the GWR’s Swindon Works. " +
            "The locomotive was withdrawn from Bristol Barrow Road depot in August 1965 and reached Barry Scrapyard in October. " +
            "In Summer 2010 the locomotive fleet was ‘one short’ for the summer peak service, resulting in the hire of 3802 from Llangollen";

        Keywords.Add("GWR 2884");
        Keywords.Add("2-8-0");
        Keywords.Add("heavy freight");
        Keywords.Add("Great Western Railway");
        Keywords.Add("Collett");
        Keywords.Add("3802");
        Keywords.Add("3850");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("3802"),
            new LocoDetails("3850"),
            });
    }
}