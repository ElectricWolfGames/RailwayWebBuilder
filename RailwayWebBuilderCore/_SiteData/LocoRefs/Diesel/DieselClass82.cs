using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass82 : DieselClassBase
{
    public DieselClass82()
    {
        ClassName = "Class 82";
        ClassDisplayName = "Class 82";
        StockType = StockTypes.Electric;

        PowerType = "Electric (25 kV AC overhead)";
        Builder = "Beyer, Peacock & Co. / AEI";
        BuildDate = "1960–1962";
        TotalProduced = 10;
        Designer = "Associated Electrical Industries / Beyer, Peacock & Co";
        WheelArrangement = "Bo-Bo";
        Power = "3,300 hp (2,461 kW)";
        MaxSpeed = "100 mph (161 km/h)";
        TractiveEffort = "50,000 lbf (222 kN)";
        LocoWeight = "83 t";
        Length = "57 ft 6 in (17.53 m)";

        Paragraph1 = "The British Rail Class 82 is a class of 25 kV AC overhead electric locomotives built for service on the newly electrified West Coast Main Line. " +
            "Ten were built between 1960 and 1962 by Beyer, Peacock and Company with electrical equipment supplied by AEI (Associated Electrical Industries). " +
            "They were part of a group of prototype electric locomotive classes (AL1–AL6, later Classes 81–86) ordered to evaluate different electrical equipment manufacturers.";
        Paragraph2 = "The Class 82s were used on express passenger services on the West Coast Main Line until superseded by more modern and numerous types. All ten were withdrawn by the early 1980s.";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 82");
        Keywords.Add("Class 82");
        Keywords.Add("electric locomotive");
        Keywords.Add("25kV AC");
        Keywords.Add("West Coast Main Line");
        Keywords.Add("Beyer Peacock");
        Keywords.Add("AEI");
        Keywords.Add("AL2");
        Keywords.Add("Bo-Bo electric");
        Keywords.Add("82008");
        Keywords.Add("locomotive photo");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("82008"),
            });
    }
}