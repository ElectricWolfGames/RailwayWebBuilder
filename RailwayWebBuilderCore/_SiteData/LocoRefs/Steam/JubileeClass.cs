using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class JubileeClass : SteamClassBase
{
    public JubileeClass()
    {
        ClassName = "Jubilee Class";
        StockType = StockTypes.SteamLoco;

        Designer = "William Stanier";
        Builder = "Crewe Works, Derby Works, North British Locomotive Company";
        BuildDate = "1934–1936";
        TotalProduced = 191;
        WhyteNotation = "4-6-0";
        Cylinders = "3 × 17 in × 26 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "6 ft 9 in";
        LeadingWheelDia = "3 ft 3½ in";
        LocoWeight = "79 tons 12 cwt";
        TenderWeight = "54 tons 12 cwt";
        Length = "62 ft 8 in";
        MaxSpeed = "90 mph";
        TractiveEffort = "26,610 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LMS_Jubilee_class";

        Paragraph1 = "The LMS Jubilee Class is a class of 4-6-0 express passenger steam locomotives introduced by the London Midland and Scottish Railway in 1934. " +
            "Designed under William Stanier, 191 locomotives were built between 1934 and 1936 at Crewe, Derby and the North British Locomotive Company. " +
            "The class was named after the Silver Jubilee of King George V in 1935, and individual locomotives were named after countries of the British Empire, naval figures, and famous battles.";

        Keywords.Add("Jubilee Class");
        Keywords.Add("William Stanier");
        Keywords.Add("4-6-0");
        Keywords.Add("LMS");
        Keywords.Add("45596");
        Keywords.Add("Bahamas");
        Keywords.Add("LMS Jubilee");
        Keywords.Add("London Midland and Scottish Railway");
        Keywords.Add("express passenger");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("45596", "Bahamas"),
            });
    }
}