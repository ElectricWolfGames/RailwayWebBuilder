using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass40 : DieselClassBase
{
    public DieselClass40()
    {
        ClassName = "Class 40";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "English Electric at Vulcan Foundry (180), Robert Stephenson and Hawthorns (20)";
        BuildDate = "1958–1962";
        TotalProduced = 200;
        Designer = "English Electric";
        WheelArrangement = "1Co-Co1";
        Engine = "English Electric 16SVT";
        Power = "2,000 hp (1,492 kW)";
        MaxSpeed = "90 mph (145 km/h)";
        TractiveEffort = "52,000 lbf (231 kN)";
        LocoWeight = "133 t";
        Length = "69 ft 6 in (21.18 m)";

        Paragraph1 = "The British Rail Class 40 is a type of British railway diesel electric locomotive. A total of 200 were built by English Electric between 1958 and 1962. They were numbered D200-D399. Despite their initial success, by the time the last examples were entering service they were already being replaced on some top-level duties by more powerful locomotives.";
        Paragraph2 = "As they were slowly relegated from express passenger uses, the type found work on secondary passenger and freight services where they worked for many years. The final locomotives ended regular service in 1985. The locomotives were commonly known as 'Whistlers' because of the distinctive noise made by their turbochargers.";
        Paragraph3 = "";

        Keywords.Add("Class 40");
        Keywords.Add("English Electric Type 4");
        Keywords.Add("Whistlers");
        Keywords.Add("D200");
        Keywords.Add("40106");
        Keywords.Add("Atlantic Conveyor");
        Keywords.Add("BR Class 40");
        Keywords.Add("British Rail");
        Keywords.Add("English Electric");
        Keywords.Add("1Co-Co1 diesel");
        Keywords.Add("diesel-electric");
        Keywords.Add("diesel locomotive");
        Keywords.Add("BR diesel");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("40106", "Atlantic Conveyor"),
            });
    }
}