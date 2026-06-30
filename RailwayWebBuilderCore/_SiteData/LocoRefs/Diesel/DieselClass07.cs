using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass07 : DieselClassBase
{
    public DieselClass07()
    {
        ClassName = "Class 07";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "Ruston & Hornsby";
        BuildDate = "1962";
        TotalProduced = 14;
        WheelArrangement = "0-6-0";
        Engine = "Paxman 6RPHL";
        Power = "275 hp (205 kW)";
        MaxSpeed = "25 mph (40 km/h)";
        TractiveEffort = "35,000 lbf (156 kN)";
        LocoWeight = "42 t";

        Paragraph1 = "The British Rail Class 07 diesel locomotive is an off-centre cab 0-6-0 diesel-electric " +
            "shunter type built by Ruston & Hornsby in 1962 for the Southern Region of British Railways. " +
            "The 14 members of the class were primarily used at Southampton Docks and later also at Eastleigh Works.";
        Paragraph2 = "";
        Overview = "";

        Keywords.Add("Class 07");
        Keywords.Add("Ruston and Hornsby");
        Keywords.Add("diesel-electric");
        Keywords.Add("shunter");
        Keywords.Add("Southampton Docks");
        Keywords.Add("D2996");
        Keywords.Add("07001");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("D2996"),
            new LocoDetails("07001"),
            });
    }
}