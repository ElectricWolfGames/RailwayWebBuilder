using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class JubileeClass : SteamClassBase
{
    public JubileeClass()
    {
        ClassName = "Jubilee Class";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The LMS Jubilee Class is a class of 4-6-0 express passenger steam locomotives introduced by the London Midland and Scottish Railway in 1934. " +
            "Designed under William Stanier, 191 locomotives were built between 1934 and 1936 at Crewe, Derby and the North British Locomotive Company. " +
            "The class was named after the Silver Jubilee of King George V in 1935, and individual locomotives were named after countries of the British Empire, naval figures, and famous battles.";

        Keywords.Add("Jubilee Class");
        Keywords.Add("William Stanier");
        Keywords.Add("4-6-0");
        Keywords.Add("LMS");
        Keywords.Add("45596");
        Keywords.Add("Bahamas");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("45596", "Bahamas"),
            });
    }
}