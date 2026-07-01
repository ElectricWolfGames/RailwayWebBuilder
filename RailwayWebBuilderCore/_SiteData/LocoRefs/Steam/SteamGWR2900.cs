using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR2900 : SteamClassBase
{
    public SteamGWR2900()
    {
        ClassName = "GWR 2900 Saint";
        StockType = StockTypes.SteamLoco;

        Designer = "George Jackson Churchward";
        Builder = "GWR Swindon Works";
        BuildDate = "1902–1913";
        TotalProduced = 77;
        WhyteNotation = "4-6-0";
        Cylinders = "2 × 18½ in × 30 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "6 ft 8½ in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "74 tons 7 cwt";
        TenderWeight = "40 tons 0 cwt";
        Length = "63 ft 0 in";
        MaxSpeed = "80 mph";
        TractiveEffort = "24,395 lbf";

        WikiLink = "https://en.wikipedia.org/wiki/GWR_2900_Class";

        Paragraph1 = "The GWR 2900 Class, commonly known as the Saint Class, is a class of 4-6-0 express passenger steam locomotives designed by George Jackson Churchward for the Great Western Railway. " +
            "Introduced in 1902, the Saints were ground-breaking in their use of long-travel valves and high-degree superheat, setting the template for British express passenger locomotive design for decades. " +
            "2999 Lady of Legend is a new-build recreation of the class, completed in 2019 by the Great Western Society at Didcot.";
        Paragraph2 = "The Saint Class directly influenced later GWR express designs including the Castle and King classes, and indirectly shaped the LMS Jubilee and BR Standard classes.";

        Keywords.Add("GWR Saint Class");
        Keywords.Add("2900 Class");
        Keywords.Add("Churchward");
        Keywords.Add("4-6-0");
        Keywords.Add("Great Western Railway");
        Keywords.Add("Lady of Legend");
        Keywords.Add("2999");
        Keywords.Add("new build");
        Keywords.Add("GWR");
        Keywords.Add("George Jackson Churchward");
        Keywords.Add("Didcot Railway Centre");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("2999", "Lady of Legend"),
            });
    }
}