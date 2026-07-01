using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWRPannierTank : SteamClassBase
{
    public SteamGWRPannierTank()
    {
        ClassName = "GWR Pannier";
        StockType = StockTypes.SteamLoco;

        Designer = "Charles Collett";
        Builder = "GWR Swindon Works";
        BuildDate = "1934–1936";
        TotalProduced = 6;
        WhyteNotation = "0-6-0PT";
        Cylinders = "2 × 16 in × 20 in";
        BoilerPressure = "165 psi";
        DriverWheelDia = "3 ft 8 in";
        LocoWeight = "35 tons 0 cwt";
        Length = "27 ft 11 in";
        MaxSpeed = "35 mph";
        TractiveEffort = "14,035 lbf";

        Paragraph1 = "The GWR 1366 Class is a class of 0-6-0 pannier tank steam locomotives designed by Charles Collett for the Great Western Railway. " +
            "Six locomotives were built at Swindon Works between 1934 and 1936, numbered 1366–1371. " +
            "Designed specifically for dock shunting and branch line work, their short wheelbase allowed them to negotiate the tight curves found in dockside areas. " +
            "Examples were notably used at Weymouth Quay and Plymouth Docks.";
        Paragraph2 = "1369 has been preserved and is based on the South Devon Railway, where it is regularly used on goods and demonstration freight workings.";

        Keywords.Add("GWR Pannier");
        Keywords.Add("1366 Class");
        Keywords.Add("Collett");
        Keywords.Add("0-6-0PT");
        Keywords.Add("Great Western Railway");
        Keywords.Add("dock shunting");
        Keywords.Add("1369");
        Keywords.Add("GWR");
        Keywords.Add("Charles Collett");
        Keywords.Add("South Devon Railway");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1369"),
            });
    }
}