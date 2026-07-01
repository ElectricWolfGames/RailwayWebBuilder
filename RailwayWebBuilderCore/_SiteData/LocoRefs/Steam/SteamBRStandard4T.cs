using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamBRStandard4T : SteamClassBase
{
    public SteamBRStandard4T()
    {
        ClassName = "BR Standard 4 Tank";
        StockType = StockTypes.SteamLoco;

        Designer = "Robert Riddles";
        Builder = "BR Brighton Works, BR Derby Works";
        BuildDate = "1951–1957";
        TotalProduced = 155;
        WhyteNotation = "2-6-4T";
        Cylinders = "2 × 18 in × 28 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "5 ft 8 in";
        LeadingWheelDia = "3 ft 0 in";
        TrailingWheelDia = "3 ft 3½ in";
        LocoWeight = "88 tons 10 cwt";
        Length = "47 ft 9⅜ in";
        MaxSpeed = "75 mph";
        TractiveEffort = "25,100 lbf";

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
        Keywords.Add("BR Standard 4 tank");
        Keywords.Add("BR Class 4 tank");
        Keywords.Add("2-6-4T");
        Keywords.Add("80079");
        Keywords.Add("80136");
        Keywords.Add("British Railways");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("80080"),
            new LocoDetails("80079"),
            new LocoDetails("80136"),
            });
    }
}