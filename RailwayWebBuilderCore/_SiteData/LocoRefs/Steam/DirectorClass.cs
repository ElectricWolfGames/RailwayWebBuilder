using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class DirectorClass : SteamClassBase
{
    public DirectorClass()
    {
        ClassName = "Director Class";
        StockType = StockTypes.SteamLoco;

        Designer = "John G. Robinson";
        Builder = "GCR Gorton Works";
        BuildDate = "1913–1925";
        TotalProduced = 23;
        WhyteNotation = "4-4-0";
        Cylinders = "2 × 20 in × 26 in";
        BoilerPressure = "180 psi";
        DriverWheelDia = "6 ft 9 in";
        LeadingWheelDia = "3 ft 6 in";
        LocoWeight = "62 tons 0 cwt";
        TenderWeight = "42 tons 0 cwt";
        Length = "56 ft 5½ in";
        MaxSpeed = "75 mph";
        TractiveEffort = "19,644 lbf";

        Paragraph1 = "The Director Class, formally classified LNER Class D11, is a class of 4-4-0 express passenger steam locomotives designed by John G. Robinson for the Great Central Railway. " +
            "The original eleven locomotives were built at the GCR's Gorton Works between 1913 and 1920, with a further twelve built by the LNER for service in Scotland between 1924 and 1925. " +
            "Named after directors of the Great Central Railway, the class was known for its elegant lines and strong performance on express passenger duties.";

        Keywords.Add("Director Class");
        Keywords.Add("LNER D11");
        Keywords.Add("John G. Robinson");
        Keywords.Add("Great Central Railway");
        Keywords.Add("4-4-0");
        Keywords.Add("GCR 506");
        Keywords.Add("Butler Henderson");
        Keywords.Add("LNER");
        Keywords.Add("GCR");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("GCR506", "Butler Henderson"),
            });
    }
}