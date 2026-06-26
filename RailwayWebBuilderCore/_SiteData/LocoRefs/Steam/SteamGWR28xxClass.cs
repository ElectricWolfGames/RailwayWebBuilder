using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWR28xxClass : SteamClassBase
{
    public SteamGWR28xxClass()
    {
        ClassName = "GWR 28xx Class Pannier";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The GWR 2800 Class (also known as the 28xx Class) is a class of 2-8-0 heavy freight steam locomotives designed by George Jackson Churchward for the Great Western Railway. " +
            "Introduced in 1903, it was the first 2-8-0 locomotive to operate in Britain. A total of 167 locomotives were built, remaining in service until the mid-1960s. " +
            "Several examples have been preserved, including 2807, which is based on the Gloucestershire Warwickshire Steam Railway.";
        Paragraph2 = "The 28xx Class was influential in shaping subsequent British freight locomotive design. Its long boiler, high superheat and long-travel valves set standards " +
            "that were widely adopted by other railway companies.";

        Keywords.Add("GWR 2800 Class");
        Keywords.Add("28xx");
        Keywords.Add("Churchward");
        Keywords.Add("2-8-0");
        Keywords.Add("Great Western Railway");
        Keywords.Add("heavy freight");
        Keywords.Add("2807");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("2807"),
            });
    }
}