using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR28xxClass : SteamClassBase
{
    public SteamGWR28xxClass()
    {
        ClassName = "GWR 28xx Class Pannier";
        StockType = StockTypes.SteamLoco;

        Designer = "George Jackson Churchward";
        Builder = "GWR Swindon Works";
        BuildDate = "1903–1919";
        TotalProduced = 84;
        WhyteNotation = "2-8-0";
        Cylinders = "2 × 18½ in × 30 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "4 ft 7½ in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "75 tons 12 cwt";
        TenderWeight = "40 tons 0 cwt";
        Length = "58 ft 9 in";
        MaxSpeed = "60 mph";
        TractiveEffort = "35,380 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/GWR_2800_Class";

        Paragraph1 = "The GWR 2800 Class (also known as the 28xx Class) is a class of 2-8-0 heavy freight steam locomotives designed by George Jackson Churchward for the Great Western Railway. " +
            "Introduced in 1903, it was the first 2-8-0 locomotive to operate in Britain. A total of 167 locomotives were built, remaining in service until the mid-1960s. " +
            "Several examples have been preserved, including 2807, which is based on the Gloucestershire Warwickshire Steam Railway.";
        Paragraph2 = "The 28xx Class was influential in shaping subsequent British freight locomotive design. Its long boiler, high superheat and long-travel valves set standards " +
            "that were widely adopted by other railway companies.";

        Keywords.Add("GWR 2800 Class");
        Keywords.Add("28xx");
        Keywords.Add("Churchward");
        Keywords.Add("2-8-0");
        Keywords.Add("Great Western Railway");
        Keywords.Add("heavy freight");
        Keywords.Add("2807");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("2807"),
            });
    }
}