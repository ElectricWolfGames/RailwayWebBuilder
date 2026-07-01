using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass14 : DieselClassBase
{
    public DieselClass14()
    {
        ClassName = "Class 14";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-hydraulic";
        Builder = "British Railways' Swindon Works";
        BuildDate = "1964–1965";
        TotalProduced = 56;
        Designer = "BR Swindon Works";
        WheelArrangement = "0-6-0";
        Engine = "Paxman Ventura 6YJXL";
        Power = "650 hp (485 kW)";
        MaxSpeed = "40 mph (64 km/h)";
        TractiveEffort = "34,500 lbf (153 kN)";
        LocoWeight = "50 t";
        Length = "34 ft 0 in (10.36 m)";

        Paragraph1 = "The British Rail Class 14 is a type of small diesel-hydraulic locomotive built in the mid-1960s. Twenty-six of these 0-6-0 locomotives were ordered in January 1963, to be built at British Railways' Swindon Works. The anticipated work for this class was trip working movements between local yards and short-distance freight trains. The good all-around visibility from the cab and dual controls also made them capable of being used for shunting duties. The order was expanded from 26 to 56 in mid-1963, before work had started on the first order. They were numbered D9500-D9555.";
        Paragraph2 = "";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 14");
        Keywords.Add("Class 14");
        Keywords.Add("diesel-hydraulic");
        Keywords.Add("trip working");
        Keywords.Add("Swindon Works");
        Keywords.Add("D9551");
        Keywords.Add("D9555");
        Keywords.Add("D9525");
        Keywords.Add("diesel locomotive");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("D9551"),
            new LocoDetails("D9555"),
            new LocoDetails("D9525"),
            });
    }
}