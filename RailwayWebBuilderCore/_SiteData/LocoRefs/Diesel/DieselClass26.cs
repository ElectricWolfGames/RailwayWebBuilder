using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass26 : DieselClassBase
{
    public DieselClass26() // TODO Need to add description
    {
        ClassName = "Class 26";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "Birmingham Railway Carriage and Wagon Company";
        BuildDate = "1958-1959";
        TotalProduced = 47;
        Designer = "Birmingham Railway Carriage and Wagon Company";
        WheelArrangement = "Bo-Bo";
        Engine = "Sulzer 6LDA28-A";
        Power = "1,160 hp (865 kW)";
        MaxSpeed = "75 mph (121 km/h)";
        TractiveEffort = "42,000 lbf (187 kN)";
        LocoWeight = "73 t";
        Length = "51 ft 1 in (15.57 m)";

        Paragraph1 = "The British Rail Class 26 diesel locomotives, also known as the BRCW Type 2, " +
            "were built by the Birmingham Railway Carriage and Wagon Company (BRCW) at Smethwick in 1958–59. " +
            "Forty seven examples were built and the last were withdrawn from service in 1994. " +
            "Like their higher-powered sisters, the BRCW Classes 27 and 33, they had all-steel bodies and cab ends with " +
            "fibreglass cab roofs. They were numbered D5300-D5346.";
        Paragraph2 = "";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 26");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("26043"),
            });
    }
}