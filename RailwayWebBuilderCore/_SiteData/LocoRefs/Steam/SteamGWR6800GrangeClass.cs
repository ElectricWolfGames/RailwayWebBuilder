using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR6800GrangeClass : SteamClassBase
{
    public SteamGWR6800GrangeClass()
    {
        ClassName = "GWR 2900 Grange";
        StockType = StockTypes.SteamLoco;

        Designer = "Charles Collett";
        Builder = "GWR Swindon Works";
        BuildDate = "1936–1939";
        TotalProduced = 81;
        WhyteNotation = "4-6-0";
        Cylinders = "2 × 18½ in × 30 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "5 ft 8 in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "69 tons 0 cwt";
        TenderWeight = "40 tons 0 cwt";
        Length = "62 ft 4 in";
        MaxSpeed = "75 mph";
        TractiveEffort = "28,875 lbf";

        WikiLink = "https://en.wikipedia.org/wiki/GWR_6800_Class";

        Paragraph1 = "The Great Western Railway (GWR) 6800 Class or Grange Class is a mixed-traffic class of 4-6-0 steam locomotive, built to replace the GWR 4300 Class 2-6-0. There were 80 originally built in the class, all built at the Swindon works, using some reconditioned parts from withdrawn 4300 Class locomotives. The 81st Grange, 6880 Betton Grange, was completed in 2024 as new member of the class.";
        Paragraph2 = "";

        Keywords.Add("GWR Grange Class");
        Keywords.Add("6800 Class");
        Keywords.Add("4-6-0");
        Keywords.Add("Great Western Railway");
        Keywords.Add("mixed traffic");
        Keywords.Add("6880");
        Keywords.Add("Betton Grange");
        Keywords.Add("new build");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("6880", "Betton Grange"),
            });
    }
}