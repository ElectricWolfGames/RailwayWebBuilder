using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass44 : DieselClassBase
{
    public DieselClass44()
    {
        ClassName = "Class 44";
        ClassDisplayName = "Class 44: Peak";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Railways' Derby Works and Crewe Works";
        BuildDate = "1959–1960";
        TotalProduced = 10;
        Designer = "BR Derby Works";
        WheelArrangement = "1Co-Co1";
        Engine = "Sulzer 12LDA28";
        Power = "2,300 hp (1,716 kW)";
        MaxSpeed = "90 mph (145 km/h)";
        TractiveEffort = "70,000 lbf (311 kN)";
        LocoWeight = "133 t";
        Length = "67 ft 11 in (20.70 m)";

        Paragraph1 = "The British Rail Class 44 is a class of ten diesel-electric 'Peak' locomotives built by British Railways at Derby Works between 1959 and 1960. " +
            "Originally numbered D1–D10, they were the first of the Peak family, which also included the more numerous Class 45 and Class 46 locomotives. " +
            "All ten were named after English mountains — including Scafell Pike, Helvellyn and Great Gable — giving rise to the 'Peak' nickname used for all three classes.";
        Paragraph2 = "The Class 44s were powered by a Sulzer 12LDA28A twin-bank twelve-cylinder engine producing 2,300 bhp. They were used on express passenger and freight services on the Midland Main Line and were all withdrawn by 1980.";
        Paragraph3 = "";

        Keywords.Add("British Rail");
        Keywords.Add("Class 44");
        Keywords.Add("Peaks");
        Keywords.Add("BR Class 44");
        Keywords.Add("Sulzer");
        Keywords.Add("1Co-Co1 diesel");
        Keywords.Add("diesel-electric");
        Keywords.Add("Midland Main Line");
        Keywords.Add("44004");
        Keywords.Add("Great Gable");
        Keywords.Add("diesel locomotive");
        Keywords.Add("BR diesel");
        Keywords.Add("locomotive photo");

        LocoNumbers.AddRange(new[] {
            new LocoDetails("44004" , "Great Gable"),
            });
    }
}