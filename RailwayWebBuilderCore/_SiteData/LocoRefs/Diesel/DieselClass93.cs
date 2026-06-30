using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass93 : DieselClassBase
{
    public DieselClass93()
    {
        ClassName = "Class 93";
        StockType = StockTypes.Diesel;

        PowerType = "Tri-mode (Electric/Diesel/Battery)";
        Builder = "Stadler Rail";
        BuildDate = "2023–";
        TotalProduced = 30;
        Designer = "Stadler Rail";
        WheelArrangement = "Bo-Bo";
        Engine = "Caterpillar C32 ACERT (diesel mode)";
        Power = "900 kW (diesel), 4,000 kW (electric)";
        MaxSpeed = "110 mph (177 km/h)";
        LocoWeight = "97 t";
        Length = "23.5 m (77 ft 1 in)";

        Paragraph1 = "The British Rail Class 93 is a class of tri-mode locomotives ordered by Rock Rail and operated by GB Railfreight, built by Stadler Rail at their Valencia factory in Spain. " +
            "Capable of operating under 25 kV AC overhead electrification, on diesel power, or under battery power, the Class 93 is one of the most flexible locomotive types ever built for the British network. " +
            "The tri-mode capability allows the class to work through electrified and non-electrified sections without changing traction power.";
        Paragraph2 = "The Class 93 is designed for both passenger charter and freight operation on mixed routes, offering significant reductions in emissions compared to pure diesel traction.";
        Overview = "";

        Keywords.Add("Class 93");
        Keywords.Add("tri-mode");
        Keywords.Add("Stadler Rail");
        Keywords.Add("GB Railfreight");
        Keywords.Add("electric diesel battery");
        Keywords.Add("93000");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("93000"),
            new LocoDetails("93001"),
            new LocoDetails("93002"),
            });
    }
}