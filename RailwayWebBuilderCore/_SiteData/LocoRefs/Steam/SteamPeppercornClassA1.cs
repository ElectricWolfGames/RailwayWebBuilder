using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamPeppercornClassA1 : SteamClassBase
{
    public SteamPeppercornClassA1()
    {
        ClassName = "Peppercorn Class A1";
        StockType = StockTypes.SteamLoco;

        Designer = "Arthur Peppercorn / A1 Steam Locomotive Trust";
        Builder = "A1 Steam Locomotive Trust, Darlington";
        BuildDate = "2008";
        TotalProduced = 1;
        WhyteNotation = "4-6-2";
        Cylinders = "3 × 19 in × 26 in";
        BoilerPressure = "250 psi";
        DriverWheelDia = "6 ft 8 in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "104 tons 0 cwt";
        TenderWeight = "60 tons 0 cwt";
        Length = "73 ft 3½ in";
        MaxSpeed = "100 mph";
        TractiveEffort = "37,397 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LNER_Peppercorn_Class_A1";

        Paragraph1 = "LNER Peppercorn Class A1 60163 Tornado is a 4-6-2 steam locomotive built by the A1 Steam Locomotive Trust." +
            "Completed in 2008 at the cost of around £3 million, it is the first newly built main line steam locomotive in the UK since Evening Star in 1960." +
            "It is the only example of an LNER Peppercorn Class A1 locomotive in existence, the entirety of the original production batch having been scrapped." +
            "60163 is named after the Panavia Tornado, a combat aircraft flown by the Royal Air Force. In 2017," +
            "Tornado became the first steam locomotive to officially reach 100 mph on British tracks for over 50 years.";

        Keywords.Add("Peppercorn A1");
        Keywords.Add("60163");
        Keywords.Add("Tornado");
        Keywords.Add("4-6-2");
        Keywords.Add("LNER");
        Keywords.Add("A1 Steam Locomotive Trust");
        Keywords.Add("new build");
        Keywords.Add("100 mph");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("60163", "Tornado"),
            });
    }
}