using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass24 : DieselClassBase
{
    public DieselClass24()
    {
        ClassName = "Class 24";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "British Railways Derby Works, Darlington Works and Crewe Works";
        BuildDate = "1958–1961";
        TotalProduced = 151;
        Designer = "BR Derby Works";
        WheelArrangement = "Bo-Bo";
        Engine = "Sulzer 6LDA28";
        Power = "1,160 hp (865 kW)";
        MaxSpeed = "90 mph (145 km/h)";
        TractiveEffort = "40,000 lbf (178 kN)";
        LocoWeight = "77 t";
        Length = "50 ft 6 in (15.39 m)";

        Paragraph1 = "The British Railways Class 24 diesel locomotives, also known as the Sulzer Type 2, were built from 1958 to 1961. One hundred and fifty-one were built at Derby, Crewe and Darlington, the first twenty of them as part of the British Railways 1955 Modernisation Plan. This class was used as the basis for the development of the Class 25 locomotives.";
        Paragraph2 = "";

        Keywords.Add("Sulzer Type 2");
        Keywords.Add("British Rail");
        Keywords.Add("Class 24");
        Keywords.Add("BR Class 24");
        Keywords.Add("Bo-Bo diesel");
        Keywords.Add("diesel-electric");
        Keywords.Add("D5054");
        Keywords.Add("Phil Southern");
        Keywords.Add("diesel locomotive");
        Keywords.Add("BR diesel");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("D5054", "Phil Southern"),
            });
    }
}