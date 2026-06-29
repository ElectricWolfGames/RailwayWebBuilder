using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamClassA4 : SteamClassBase
{
    public SteamClassA4()
    {
        ClassName = "Class A4";
        StockType = StockTypes.SteamLoco;

        Designer = "Nigel Gresley";
        Builder = "Doncaster Works";
        BuildDate = "1935–1938";
        TotalProduced = 35;
        WhyteNotation = "4-6-2";
        Cylinders = "3 × 18½ in × 26 in";
        BoilerPressure = "250 psi";
        DriverWheelDia = "6 ft 8 in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "102 tons 19 cwt";
        TenderWeight = "64 tons 0 cwt";
        Length = "71 ft 0 in";
        MaxSpeed = "126 mph (Mallard world record)";
        TractiveEffort = "35,455 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LNER_Class_A4";

        Paragraph1 = "The Class A4 is a class of streamlined 4-6-2 steam locomotive designed by Nigel Gresley " +
            "for the London and North Eastern Railway in 1935. Their streamlined design gave them high-speed capability as well as making " +
            "them instantly recognisable, and one of the class, 4468 Mallard, holds the world record as the fastest steam locomotive. " +
            "Thirty-five of the class were built to haul express passenger trains on the East Coast Main Line route from London Kings Cross via " +
            "York to Newcastle, and later via Newcastle to Edinburgh, Scotland. They remained in service on the East Coast Main Line until " +
            "the early 1960s when they were replaced by Deltic diesel locomotives; they themselves proving to be worthy successors to the A4s. " +
            "Several A4s saw out their remaining days until 1966 in Scotland, particularly on the Aberdeen – Glasgow express trains, " +
            "for which they were used to improve the timing from 3.5 to 3 hours.";

        Keywords.Add("LNER A4");
        Keywords.Add("Nigel Gresley");
        Keywords.Add("4-6-2 streamlined");
        Keywords.Add("60007");
        Keywords.Add("Sir Nigel Gresley");
        Keywords.Add("Mallard");
        Keywords.Add("world speed record");
        Keywords.Add("East Coast Main Line");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("60007"),
            });
    }
}