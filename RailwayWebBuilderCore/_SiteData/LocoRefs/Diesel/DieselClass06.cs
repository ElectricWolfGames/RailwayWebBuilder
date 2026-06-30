using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass06 : DieselClassBase
{
    public DieselClass06()
    {
        ClassName = "Class 06";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-mechanical";
        Builder = "Andrew Barclay Sons & Co.";
        BuildDate = "1958–1960";
        TotalProduced = 35;
        WheelArrangement = "0-4-0";
        Engine = "Gardner 6L3";
        Power = "153 hp (114 kW)";
        MaxSpeed = "21 mph (34 km/h)";
        TractiveEffort = "15,650 lbf (69.6 kN)";
        LocoWeight = "21 t 10 cwt";

        Paragraph1 = "The British Rail Class 06 is a class of 0-4-0 diesel-mechanical shunters built by Andrew Barclay Sons and Company from 1958 to 1960 for use on the Scottish Region of British Railways.";
        Paragraph2 = "They were originally numbered D2410–D2444 and survivors after 1973 were given the TOPS numbers 06001–06010.";
        Overview = "";

        Keywords.Add("Class 06");
        Keywords.Add("Andrew Barclay");
        Keywords.Add("diesel-mechanical");
        Keywords.Add("shunter");
        Keywords.Add("Scottish Region");
        Keywords.Add("06003");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("06003"),
            });
    }
}