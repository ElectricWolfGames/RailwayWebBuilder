using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class LMSStanierMogul : SteamClassBase
{
    public LMSStanierMogul()
    {
        ClassName = "Stanier Mogul";
        StockType = StockTypes.SteamLoco;

        Designer = "George Hughes / Henry Fowler";
        Builder = "Crewe Works, Horwich Works";
        BuildDate = "1926–1932";
        TotalProduced = 245;
        WhyteNotation = "2-6-0";
        Cylinders = "2 × 21 in × 26 in";
        BoilerPressure = "180 psi";
        DriverWheelDia = "5 ft 6 in";
        LeadingWheelDia = "3 ft 0 in";
        LocoWeight = "66 tons 10 cwt";
        TenderWeight = "42 tons 5 cwt";
        Length = "58 ft 4 in";
        MaxSpeed = "65 mph";
        TractiveEffort = "26,580 lbf";

        Paragraph1 = "The LMS Hughes Fowler 'Crab' 2-6-0 is a class of mixed-traffic steam locomotive introduced by the London Midland and Scottish Railway in 1926. " +
            "Designed by George Hughes and refined by Henry Fowler, 245 locomotives were built between 1926 and 1932. " +
            "The class earned their 'Crab' nickname from their distinctive inclined outside cylinders, which gave the motion a crab-like appearance. " +
            "They were used across a wide variety of LMS services, from express freight to secondary passenger workings.";

        Keywords.Add("Stanier Mogul");
        Keywords.Add("Crab");
        Keywords.Add("Hughes Fowler");
        Keywords.Add("2-6-0");
        Keywords.Add("LMS");
        Keywords.Add("13268");
        Keywords.Add("London Midland and Scottish Railway");
        Keywords.Add("George Hughes");
        Keywords.Add("Henry Fowler");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("13268"),
            });
    }
}