using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLYRClass27 : SteamClassBase
{
    public SteamLYRClass27()
    {
        ClassName = "L&YR Class 27 ";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The Lancashire and Yorkshire Railway Class 27 is a class of 0-6-0 steam locomotive designed for freight work on the Lancashire and Yorkshire Railway.";
        Paragraph2 = "Aspinall opted for a two-cylinder format with a non superheated round top boiler. David Joy's configuration of valve gear was employed. By the time Aspinall became general manager of the L&YR on 1 July 1899 more than 400 of the simple but powerful engines had been built. More were built under his successors, Henry Hoy and George Hughes, albeit with some modifications. By 1918 there were the 484 locomotives in the class.";

        Keywords.Add("L&YR Class 27");
        Keywords.Add("Lancashire and Yorkshire Railway");
        Keywords.Add("0-6-0");
        Keywords.Add("Aspinall");
        Keywords.Add("freight");
        Keywords.Add("52322");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("52322"),
            });
    }
}