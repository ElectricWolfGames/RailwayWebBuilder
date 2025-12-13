using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamCaledonianRailwayClass439 : SteamClassBase
{
    public SteamCaledonianRailwayClass439()
    {
        ClassName = "Caledonian Railway Class 439";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The Caledonian Railway 439 Class is a class of 0-4-4T steam locomotive. It was a development of earlier Caledonian Railway 0-4-4T locomotives, including the 19 Class and 92 Class, and predecessor of the 431 Class. The 439 Class was introduced by John F. McIntosh in 1900 and a modified version was introduced by William Pickersgill in 1915.";
        Paragraph2 = "Ninety-two engines of the class were built between 1900 and 1925, a few under LMS auspices. Seventy-four Class 439s passed into British Railways ownership in 1948 and they were numbered 55159-55236 (with gaps).";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("No419"),
            });
    }
}