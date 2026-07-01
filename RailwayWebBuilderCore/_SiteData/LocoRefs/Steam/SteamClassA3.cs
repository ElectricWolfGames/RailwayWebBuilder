using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamClassA3 : SteamClassBase
{
    public SteamClassA3()
    {
        ClassName = "Class A3";
        StockType = StockTypes.SteamLoco;

        Designer = "Nigel Gresley";
        Builder = "Doncaster Works";
        BuildDate = "1928–1935";
        TotalProduced = 79;
        WhyteNotation = "4-6-2";
        Cylinders = "3 × 19 in × 26 in";
        BoilerPressure = "250 psi";
        DriverWheelDia = "6 ft 8 in";
        LeadingWheelDia = "3 ft 2 in";
        LocoWeight = "96 tons 0 cwt";
        TenderWeight = "57 tons 8 cwt";
        Length = "70 ft 5 in";
        MaxSpeed = "100 mph";
        TractiveEffort = "32,909 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LNER_Class_A3";

        Paragraph1 = "The LNER Class A3 is a class of 4-6-2 Pacific steam locomotives designed by Nigel Gresley for the London and North Eastern Railway. " +
            "The A3 was a development of the earlier A1 class, incorporating a number of improvements including a higher boiler pressure and improved draughting following trials with a French compound locomotive. " +
            "The most famous member of the class is 60103 Flying Scotsman, which in 1934 became the first locomotive officially verified to have reached 100 mph (161 km/h) in service.";
        Paragraph2 = "Flying Scotsman hauled the first non-stop London to Edinburgh service in 1928. After withdrawal in 1963, it was purchased for preservation by Alan Pegler and has since become one of the most recognised steam locomotives in the world. It is currently part of the National Railway Museum collection.";

        Keywords.Add("LNER A3");
        Keywords.Add("Nigel Gresley");
        Keywords.Add("4-6-2");
        Keywords.Add("Flying Scotsman");
        Keywords.Add("60103");
        Keywords.Add("Pacific");
        Keywords.Add("London and North Eastern Railway");
        Keywords.Add("LNER");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("East Coast Main Line");
        Keywords.Add("Doncaster Works");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("60103", "Flying Scotsman"),
            });
    }
}