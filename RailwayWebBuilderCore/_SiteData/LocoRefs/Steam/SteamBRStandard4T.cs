using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamBRStandard4T : SteamClassBase
{
    public SteamBRStandard4T()
    {
        ClassName = "BR Standard 4 Tank";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The British Railways Standard Class 4 tank is a class of steam locomotive, " +
            "one of the BR standard classes built during the 1950s. They were used primarily on commuter and outer suburban services. " +
            "They were capable of reaching speeds of 75 mph (113 km/h).";
        Paragraph2 = "The Standard 4 tanks were originally allocated to all regions of British Railways, " +
            "bar the Western. They became particularly associated with the London, Tilbury and Southend line (LT&S) " +
            "working commuter services out of London, until that route was electrified in 1962. They were also widely " +
            "used in East Sussex and Kent, working from Brighton, Tunbridge Wells and Three Bridges on those lines of " +
            "the former London Brighton and South Coast Railway that were not electrified. Another group worked from " +
            "Polmadie depot in the Scottish region on the Glasgow commuter services. Note that, from July 1962, " +
            "a batch displaced by electrification of the LT&S was transferred to the Western Region's Swansea (East Dock) " +
            "and Shrewsbury districts, as well as other regions.";

        Keywords.Add("Robert Riddles");
        Keywords.Add("Standard Class 4 tank");
        Keywords.Add("80080");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("80080"),
            new LocoDetails("80079"),
            new LocoDetails("80136"),
            });
    }
}