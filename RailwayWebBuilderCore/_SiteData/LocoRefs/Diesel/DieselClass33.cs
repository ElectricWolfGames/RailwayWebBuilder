using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;

public class DieselClass33 : DieselClassBase
{
    public DieselClass33()
    {
        ClassName = "Class 33";
        StockType = StockTypes.Diesel;

        PowerType = "Diesel-electric";
        Builder = "Birmingham Railway Carriage and Wagon Company";
        BuildDate = "1960–1962";
        TotalProduced = 98;
        Designer = "Birmingham Railway Carriage and Wagon Company";
        WheelArrangement = "Bo-Bo";
        Engine = "Sulzer 8LDA28";
        Power = "1,550 hp (1,156 kW)";
        MaxSpeed = "85 mph (137 km/h)";
        TractiveEffort = "45,000 lbf (200 kN)";
        LocoWeight = "77 t";
        Length = "50 ft 9 in (15.47 m)";

        Paragraph1 = "The British Rail Class 33, also known as the BRCW Type 3 or Crompton, is a class of Bo-Bo diesel-electric locomotives, ordered in 1957 and built for the Southern Region of British Railways between 1960 and 1962.";
        Paragraph2 = "They were produced as a more powerful Type 3 (1,550 bhp) development of the 1,160 bhp Type 2 Class 26. This was achieved by removing the steam heating boiler and fitting a larger 8-cylinder version of the previous 6-cylinder engine. Thus, they became the most powerful BR Bo-Bo diesel locomotive. A total of 98 were built by the Birmingham Railway Carriage and Wagon Company (BRCW) and they were known as 'Cromptons' after the Crompton Parkinson electrical equipment installed in them.";
        Paragraph3 = "Like their lower-powered BRCW sisters, the Class 26 and Class 27 locomotives, their bodywork and cab ends were of all steel construction. They were very similar in appearance to Class 26 locos, but carried Southern Region two-digit headcode blinds between the cab windows.";

        Keywords.Add("British Rail");
        Keywords.Add("British Rail Class 33");
        Keywords.Add("BRCW Type 3");
        Keywords.Add("Crompton");
        Keywords.Add("Class 33");
        Keywords.Add("Southern Region");
        Keywords.Add("Bo-Bo diesel");
        Keywords.Add("diesel-electric");
        Keywords.Add("33201");
        Keywords.Add("D6508");
        Keywords.Add("D6535");
        Keywords.Add("33108");
        Keywords.Add("diesel locomotive");
        Keywords.Add("BR diesel");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("33201"),
            new LocoDetails("D6508"),
            new LocoDetails("D6535"),
            new LocoDetails("33108")
            });
    }
}