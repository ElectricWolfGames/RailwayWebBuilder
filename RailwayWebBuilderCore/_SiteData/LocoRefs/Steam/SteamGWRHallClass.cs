using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWRHallClass : SteamClassBase
{
    public SteamGWRHallClass()
    {
        ClassName = "GWR Hall Class";
        StockType = StockTypes.SteamLoco;

        Designer = "Charles Collett";
        Builder = "GWR Swindon Works";
        BuildDate = "1928–1950";
        TotalProduced = 259;
        WhyteNotation = "4-6-0";
        Cylinders = "2 × 18½ in × 30 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "6 ft 0 in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "75 tons 0 cwt";
        TenderWeight = "40 tons 0 cwt";
        Length = "63 ft 0 in";
        MaxSpeed = "90 mph";
        TractiveEffort = "27,275 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/GWR_4900_Class";

        Paragraph1 = "The Great Western Railway 4900 Class or Hall Class is a class of 4-6-0 mixed traffic steam locomotives designed by Charles Collett " +
                      "for the Great Western Railway. A total of 259 were built at Swindon Works, numbered 4900–4999, 5900–5999 and 6900–6958. " +
                      "The LMS Stanier Class 5 4-6-0 and LNER Thompson Class B1 both drew heavily on design features of the Hall Class. " +
                      "After nationalisation in 1948, British Railways gave them the power classification 5MT.";

        Keywords.Add("Charles Collett");
        Keywords.Add("classification 5MT");
        Keywords.Add("Great Western Railway");
        Keywords.Add("Hall");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("6988", "SwithlandHall"),
            new LocoDetails("6990", "Witherslack Hall")
            });
    }
}