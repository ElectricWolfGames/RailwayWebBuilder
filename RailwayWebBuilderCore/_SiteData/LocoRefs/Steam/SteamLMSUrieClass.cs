using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLMSUrieClass : SteamClassBase
{
    public SteamLMSUrieClass()
    {
        ClassName = "LMS Urie Class S15";
        StockType = StockTypes.SteamLoco;

        Designer = "Robert Urie / Richard Maunsell";
        Builder = "Eastleigh Works";
        BuildDate = "1920–1936";
        TotalProduced = 45;
        WhyteNotation = "4-6-0";
        Cylinders = "2 × 21 in × 28 in";
        BoilerPressure = "200 psi";
        DriverWheelDia = "5 ft 7 in";
        LeadingWheelDia = "3 ft 7 in";
        LocoWeight = "79 tons 16 cwt";
        TenderWeight = "53 tons 0 cwt";
        Length = "63 ft 6 in";
        MaxSpeed = "70 mph";
        TractiveEffort = "29,855 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LSWR_S15_class";

        Paragraph1 = "The LSWR S15 class is a British 2-cylinder 4-6-0 freight steam locomotive designed by Robert W. Urie, based on his H15 class and N15 class locomotives. The class had a complex build history, spanning several years of construction from 1920 to 1936. The first examples were constructed for the London and South Western Railway (LSWR), where they hauled freight trains to the south coast ports and further west to Exeter, as well as occasional passenger work in conjunction with their larger-wheeled N15 class counterparts";
        Paragraph2 = "Following the Grouping of railway companies in 1923, the LSWR became part of the Southern Railway, and the Chief Mechanical Engineer (CME) of the newly formed company, Richard Maunsell, increased the S15 class strength to 45 locomotives. Maunsell incorporated several improvements, notably to the steam circuit and the locomotive's loading gauge, allowing it to operate on routes with height and width restrictions";

        Keywords.Add("LSWR S15");
        Keywords.Add("Urie S15");
        Keywords.Add("4-6-0");
        Keywords.Add("Robert Urie");
        Keywords.Add("Richard Maunsell");
        Keywords.Add("Southern Railway");
        Keywords.Add("freight");
        Keywords.Add("506");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("506"),
            });
    }
}