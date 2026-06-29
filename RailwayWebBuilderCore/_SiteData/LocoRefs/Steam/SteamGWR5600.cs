using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR5600 : SteamClassBase
{
    public SteamGWR5600()
    {
        ClassName = "GWR 5600";
        StockType = StockTypes.SteamLoco;

        Designer = "Charles Collett";
        Builder = "GWR Swindon Works, North British Locomotive Co";
        BuildDate = "1924–1928";
        TotalProduced = 200;
        WhyteNotation = "0-6-2T";
        Cylinders = "2 × 18 in × 26 in";
        BoilerPressure = "200 psi";
        DriverWheelDia = "4 ft 7½ in";
        TrailingWheelDia = "3 ft 8 in";
        LocoWeight = "73 tons 15 cwt";
        Length = "38 ft 4 in";
        MaxSpeed = "60 mph";
        TractiveEffort = "25,800 lbf";

        Paragraph1 = "The GWR 5600 Class is a class of 0-6-2T steam locomotive built between 1924 and 1928. They were designed by Charles Collett for the Great Western Railway (GWR), and were introduced into traffic in 1924. After the 1923 grouping, Swindon inherited a large and variable collection of locomotives from historic Welsh railway companies, which did not fit into their standardisation programme. GWR boiler inspectors arrived en masse and either condemned the original locomotives or had them rebuilt. The systematic destruction of many examples of locomotives, most still in serviceable condition, followed, but various were worked alongside 5600 Class.";
        Paragraph2 = "Two hundred GWR 5600 Class replacement locomotives were built and remained in service until withdrawn by British Railways between 1962 and 1965. Nine of the class have survived into preservation.";

        Keywords.Add("GWR 5600 Class");
        Keywords.Add("0-6-2T");
        Keywords.Add("Charles Collett");
        Keywords.Add("Great Western Railway");
        Keywords.Add("Welsh valleys");
        Keywords.Add("6695");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("6695"),
            });
    }
}