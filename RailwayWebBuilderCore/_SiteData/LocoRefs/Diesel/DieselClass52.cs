using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass52 : DieselClassBase
{
    public DieselClass52()
    {
        ClassName = "Class 52";
        ClassDisplayName = "Class 52: Western";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-hydraulic";
        Builder = "Swindon Works (30), Crewe Works (44)";
        BuildDate = "1961–1964";
        TotalProduced = 74;
        Designer = "BR Swindon / BR Crewe";
        WheelArrangement = "C-C";
        Engine = "2 × Bristol-Siddeley Maybach MD655";
        Power = "2,700 hp (2,014 kW)";
        MaxSpeed = "90 mph (145 km/h)";
        TractiveEffort = "72,600 lbf (323 kN)";
        LocoWeight = "108 t";
        Length = "68 ft 0 in (20.73 m)";

        Paragraph1 = "The British Rail Class 52 is a class of 74 Type 4 diesel-hydraulic locomotives built for the Western Region of British Railways between 1961 and 1964. All were given two-word names, the first word being 'Western' and thus the type became known as Westerns. They were also known as Wizzos and Thousands. The final Class 52 locomotives were withdrawn from service in 1977.";
        Paragraph2 = "";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 52");
        Keywords.Add("Western");
        Keywords.Add("Wizzos");
        Keywords.Add("diesel-hydraulic");
        Keywords.Add("Western Region");
        Keywords.Add("D1013");
        Keywords.Add("D1015");
        Keywords.Add("D1062");
        Keywords.Add("Western Ranger");
        Keywords.Add("Western Champion");
        Keywords.Add("Western Courier");
        Keywords.Add("Maybach");
        Keywords.Add("diesel locomotive");
        Keywords.Add("BR diesel");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("D1013", "Western Ranger"),
            new LocoDetails("D1015", "Western Champion"),
            new LocoDetails("D1062", "Western Courier"),
            });
    }
}