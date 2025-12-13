using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamBRStandard5 : SteamClassBase
{
    public SteamBRStandard5()
    {
        ClassName = "BR Standard 5";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The British Railways Standard Class 5MT 4-6-0 was one of the 12 standard classes of steam locomotive built by British Railways in the 1950s." +
                   "It was essentially a development of the LMS Stanier Class 5 4-6-0 ('Black Five'). A total of 172 were built between 1951 and 1957.";
        Paragraph2 = "William Stanier's Black Five had been the most successful mixed-traffic type in Great Britain." +
            "Construction of the Black Fives had started in 1934 and continued past nationalisation to 1951. " +
            "A new set of 'standard' locomotives was to be built by British Railways, based on LMS designs and incorporating modern ideas.";

        Keywords.Add("BR Standard Class 5");
        Keywords.Add("class 5");
        Keywords.Add("1960");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("73156"),
            new LocoDetails("73082", "Camelot"),
            });
    }
}