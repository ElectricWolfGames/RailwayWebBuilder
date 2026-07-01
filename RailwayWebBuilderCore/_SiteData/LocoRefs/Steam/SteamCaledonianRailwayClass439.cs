using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamCaledonianRailwayClass439 : SteamClassBase
{
    public SteamCaledonianRailwayClass439()
    {
        ClassName = "Caledonian Railway Class 439";
        StockType = StockTypes.SteamLoco;

        Designer = "John F. McIntosh / William Pickersgill";
        Builder = "St Rollox Works, Neilson Reid & Co";
        BuildDate = "1900–1925";
        TotalProduced = 92;
        WhyteNotation = "0-4-4T";
        Cylinders = "2 × 18 in × 26 in";
        BoilerPressure = "160 psi";
        DriverWheelDia = "5 ft 9 in";
        TrailingWheelDia = "3 ft 8 in";
        LocoWeight = "59 tons 0 cwt";
        Length = "37 ft 9 in";
        MaxSpeed = "60 mph";
        TractiveEffort = "17,590 lbf";

        Paragraph1 = "The Caledonian Railway 439 Class is a class of 0-4-4T steam locomotive. It was a development of earlier Caledonian Railway 0-4-4T locomotives, including the 19 Class and 92 Class, and predecessor of the 431 Class. The 439 Class was introduced by John F. McIntosh in 1900 and a modified version was introduced by William Pickersgill in 1915.";
        Paragraph2 = "Ninety-two engines of the class were built between 1900 and 1925, a few under LMS auspices. Seventy-four Class 439s passed into British Railways ownership in 1948 and they were numbered 55159-55236 (with gaps).";

        Keywords.Add("Caledonian Railway");
        Keywords.Add("439 Class");
        Keywords.Add("0-4-4T");
        Keywords.Add("John McIntosh");
        Keywords.Add("William Pickersgill");
        Keywords.Add("No419");
        Keywords.Add("CR");
        Keywords.Add("Scottish steam");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("No419"),
            });
    }
}