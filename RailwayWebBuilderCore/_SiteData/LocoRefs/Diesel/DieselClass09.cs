using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass09 : DieselClassBase
{
    public DieselClass09()
    {
        ClassName = "Class 09";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Railways, Darlington Works";
        BuildDate = "1959–1962";
        TotalProduced = 26;
        WheelArrangement = "0-6-0";
        Engine = "English Electric 6KT";
        Power = "400 hp (298 kW)";
        MaxSpeed = "27 mph (43 km/h)";
        TractiveEffort = "25,000 lbf (111 kN)";
        LocoWeight = "49 t 18 cwt";
        Length = "29 ft 3 in (8.92 m)";

        Paragraph1 = "The British Rail Class 09 is a class of diesel-electric shunting locomotives, essentially a more powerful variant of the Class 08. " +
            "Twenty-six were built at Darlington Works between 1959 and 1962, primarily for the Southern Region of British Railways. " +
            "The Class 09 was geared for a higher top speed of 27 mph (43 km/h) compared to the Class 08's 15 mph (24 km/h), making them better suited to trip working between sidings and yards.";
        Paragraph2 = "The class remained in service on the Southern Region for many years. Several examples have survived into preservation on heritage railways.";
        Overview = "";

        Keywords.Add("Class 09");
        Keywords.Add("diesel-electric shunter");
        Keywords.Add("Darlington Works");
        Keywords.Add("Southern Region");
        Keywords.Add("09001");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("09001"),
            });
    }
}