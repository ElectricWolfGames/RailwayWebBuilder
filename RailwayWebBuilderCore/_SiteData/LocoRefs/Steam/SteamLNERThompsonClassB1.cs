using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLNERThompsonClassB1 : SteamClassBase
{
    public SteamLNERThompsonClassB1()
    {
        ClassName = "LNER Thompson Class B1";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The London and North Eastern Railway (LNER) Thompson Class B1 is a class of steam locomotive designed by Edward Thompson for medium mixed traffic work.";
        Paragraph2 = "It was the LNER's equivalent to the highly successful GWR Hall Class and the LMS Stanier Black Five, two-cylinder mixed traffic 4-6-0s. However, it had the additional requirement of having to be cheap because, due to wartime and post-war economies, the LNER, never the richest railway company, had to make savings.";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1264"),
            });
    }
}