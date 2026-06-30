using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass46 : DieselClassBase
{
    public DieselClass46()
    {
        ClassName = "Class 46";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Railways’ Derby Works";
        BuildDate = "1961–1963";
        TotalProduced = 56;
        Designer = "BR Derby Works";
        WheelArrangement = "1Co-Co1";
        Engine = "Sulzer 12LDA28B";
        Power = "2,500 hp (1,864 kW)";
        MaxSpeed = "90 mph (145 km/h)";
        TractiveEffort = "70,000 lbf (311 kN)";
        LocoWeight = "138 t";
        Length = "67 ft 11 in (20.70 m)";

        Paragraph1 = "The British Rail Class 46 is a class of diesel locomotive. They were built from 1961 to 1963 at British Railways' Derby Works and were initially numbered D138–D193.";
        Paragraph2 = "Fifty-six locomotives were built. The first was withdrawn in 1977 and all were withdrawn by the end of 1984.";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 46");
        Keywords.Add("Class 46");
        Keywords.Add("Peaks");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("46010"),
            new LocoDetails("D182")
            });
    }
}