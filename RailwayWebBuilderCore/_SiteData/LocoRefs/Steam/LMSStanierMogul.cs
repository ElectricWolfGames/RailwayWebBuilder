using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class LMSStanierMogul : SteamClassBase
{
    public LMSStanierMogul()
    {
        ClassName = "Stanier Mogul";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The LMS Hughes Fowler 'Crab' 2-6-0 is a class of mixed-traffic steam locomotive introduced by the London Midland and Scottish Railway in 1926. " +
            "Designed by George Hughes and refined by Henry Fowler, 245 locomotives were built between 1926 and 1932. " +
            "The class earned their 'Crab' nickname from their distinctive inclined outside cylinders, which gave the motion a crab-like appearance. " +
            "They were used across a wide variety of LMS services, from express freight to secondary passenger workings.";

        Keywords.Add("Stanier Mogul");
        Keywords.Add("Crab");
        Keywords.Add("Hughes Fowler");
        Keywords.Add("2-6-0");
        Keywords.Add("LMS");
        Keywords.Add("13268");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("13268"),
            });
    }
}