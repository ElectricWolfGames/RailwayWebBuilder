using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class DirectorClass : SteamClassBase
{
    public DirectorClass()
    {
        ClassName = "Director Class";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The Director Class, formally classified LNER Class D11, is a class of 4-4-0 express passenger steam locomotives designed by John G. Robinson for the Great Central Railway. " +
            "The original eleven locomotives were built at the GCR's Gorton Works between 1913 and 1920, with a further twelve built by the LNER for service in Scotland between 1924 and 1925. " +
            "Named after directors of the Great Central Railway, the class was known for its elegant lines and strong performance on express passenger duties.";

        Keywords.Add("Director Class");
        Keywords.Add("LNER D11");
        Keywords.Add("John G. Robinson");
        Keywords.Add("Great Central Railway");
        Keywords.Add("4-4-0");
        Keywords.Add("GCR 506");
        Keywords.Add("Butler Henderson");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("GCR506", "Butler Henderson"),
            });
    }
}