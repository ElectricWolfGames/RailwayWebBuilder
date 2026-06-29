using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLNERThompsonClassB1 : SteamClassBase
{
    public SteamLNERThompsonClassB1()
    {
        ClassName = "LNER Thompson Class B1";
        StockType = StockTypes.SteamLoco;

        Designer = "Edward Thompson";
        Builder = "Gorton Works, Darlington Works, North British Locomotive Co, Vulcan Foundry";
        BuildDate = "1942–1952";
        TotalProduced = 410;
        WhyteNotation = "4-6-0";
        Cylinders = "2 × 20 in × 26 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "6 ft 2 in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "71 tons 0 cwt";
        TenderWeight = "52 tons 10 cwt";
        Length = "63 ft 7 in";
        MaxSpeed = "90 mph";
        TractiveEffort = "26,878 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LNER_Thompson_Class_B1";

        Paragraph1 = "The London and North Eastern Railway (LNER) Thompson Class B1 is a class of steam locomotive designed by Edward Thompson for medium mixed traffic work.";
        Paragraph2 = "It was the LNER's equivalent to the highly successful GWR Hall Class and the LMS Stanier Black Five, two-cylinder mixed traffic 4-6-0s. However, it had the additional requirement of having to be cheap because, due to wartime and post-war economies, the LNER, never the richest railway company, had to make savings.";

        Keywords.Add("LNER B1");
        Keywords.Add("Thompson Class B1");
        Keywords.Add("4-6-0");
        Keywords.Add("Edward Thompson");
        Keywords.Add("mixed traffic");
        Keywords.Add("London and North Eastern Railway");
        Keywords.Add("1264");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1264"),
            });
    }
}