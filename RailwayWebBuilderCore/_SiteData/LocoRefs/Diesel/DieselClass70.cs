using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass70 : DieselClassBase
{
    public DieselClass70()
    {
        ClassName = "Class 70";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "General Electric Transportation";
        BuildDate = "2009–2012";
        TotalProduced = 20;
        Designer = "General Electric Transportation";
        WheelArrangement = "Co-Co";
        Engine = "GE PowerHaul P616";
        Power = "3,690 hp (2,753 kW)";
        MaxSpeed = "75 mph (121 km/h)";
        TractiveEffort = "122,400 lbf (544 kN)";
        LocoWeight = "129 t";
        Length = "72 ft 2 in (22.00 m)";

        Paragraph1 = "The British Rail Class 70 PowerHaul is a class of diesel-electric freight locomotives built by General Electric Transportation at Erie, Pennsylvania, USA. " +
            "Twenty were delivered to Freightliner between 2009 and 2012, numbered 70001–70020. " +
            "They are powered by a GE PowerHaul P616 prime mover producing 3,690 hp (2,750 kW) and are used on heavy intermodal container and infrastructure freight trains.";
        Paragraph2 = "The Class 70 introduced North American locomotive design practice to the British network. They have proved capable but their non-standard technology has made maintenance more complex compared to domestic designs.";
        Overview = "";

        Keywords.Add("Class 70");
        Keywords.Add("PowerHaul");
        Keywords.Add("General Electric");
        Keywords.Add("Freightliner");
        Keywords.Add("freight");
        Keywords.Add("70001");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("77020"),
            });
    }
}