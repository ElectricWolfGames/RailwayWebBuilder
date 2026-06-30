using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass31 : DieselClassBase
{
    public DieselClass31()
    {
        ClassName = "Class 31";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "Brush Traction";
        BuildDate = "1957–1962";
        TotalProduced = 263;
        Designer = "Brush Traction";
        WheelArrangement = "A1A-A1A";
        Engine = "English Electric 12SVT (later Mirrlees JVS12T)";
        Power = "1,470 hp (1,096 kW)";
        MaxSpeed = "90 mph (145 km/h)";
        TractiveEffort = "42,000 lbf (187 kN)";
        LocoWeight = "111 t";
        Length = "56 ft 9 in (17.30 m)";

        Paragraph1 = "The British Rail Class 31 diesel locomotives, " +
            "also known as the Brush Type 2 and previously as Class 30, " +
            "were built by Brush Traction from 1957 to 1962. " +
            "They were numbered in two series, D5500-D5699 and D5800-D5862.";
        Paragraph2 = "Construction of the first locomotive was completed in the final week of September 1957, " +
            "and the handing-over took place on 31 October. " +
            "The first Class 31 entered service in November 1957, " +
            "after the launch of the Class 20 locomotive and was one of the Pilot Scheme locomotives ordered by British Railways to replace steam traction.";
        Paragraph3 = "";

        Keywords.Add("Class 31");
        Keywords.Add("Brush Type 2");
        Keywords.Add("Brush Traction");
        Keywords.Add("Class 30");
        Keywords.Add("31466");
        Keywords.Add("D5500");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("31466"),
            new LocoDetails("31210"),
            new LocoDetails("31108"),
            new LocoDetails("31289"),
            new LocoDetails("31235"),
            });
    }
}