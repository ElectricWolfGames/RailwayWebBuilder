using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass43 : DieselClassBase
{
    public DieselClass43()
    {
        ClassName = "Class 43";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Rail Engineering Limited Crewe Works";
        BuildDate = "1975-1982";
        TotalProduced = 197;
        Designer = "BR Research / BREL";
        WheelArrangement = "Bo-Bo";
        Engine = "Paxman Valenta 12RP200L (later MTU 16V4000 R41R)";
        Power = "2,250 hp (1,679 kW)";
        MaxSpeed = "125 mph (201 km/h)";
        TractiveEffort = "17,980 lbf (80 kN)";
        LocoWeight = "70 t";
        Length = "58 ft 5 in (17.80 m)";

        Paragraph1 = "The British Rail Class 43 (HST) is the TOPS classification used for the InterCity 125 High Speed Train (formerly Classes 253 and 254) diesel-electric power cars, built by British Rail Engineering Limited from 1975 to 1982, and in service in the UK since 1976.";
        Paragraph2 = "The class is officially the fastest diesel locomotive in the world, with an absolute maximum speed of 148.5 mph (239.0 km/h), and a regular service speed of 125 mph (201 km/h). The record run was led by 43102 (43302) and trailed by 43159.";
        Paragraph3 = "";

        Keywords.Add("Class 43");
        Keywords.Add("HST");
        Keywords.Add("InterCity 125");
        Keywords.Add("High Speed Train");
        Keywords.Add("43025");
        Keywords.Add("125 mph");
        Keywords.Add("British Rail");
        Keywords.Add("BREL");
        Keywords.Add("Paxman Valenta");
        Keywords.Add("diesel power car");
        Keywords.Add("43044");
        Keywords.Add("diesel locomotive");
        Keywords.Add("locomotive photo");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("43025"),
            new LocoDetails("43044"),
            });
    }
}