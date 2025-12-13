using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLMSStanier8F : SteamClassBase
{
    public SteamLMSStanier8F()
    {
        ClassName = "LMS Stanier 8F Class";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The London Midland and Scottish Railway's class 8F is a class of steam locomotive designed for hauling heavy freight. " +
            "852 were built between 1935 and 1946 (not all to LMS order), as a freight version of William Stanier's successful Black Five, " +
            "and the class saw extensive service overseas during and after the Second World War.";
        Paragraph2 = "LMS freight traction suffered from the adoption of the Midland Railway's small engine policy which had left it with trains" +
            "double-headed by underpowered 0-6-0s supplemented by disappointing Garratts and Fowler 7F 0-8-0s. The 8F design incorporated the" +
            "two-cylinder arrangement of the Black Fives.They were initially classified 7F, but this was later changed to the more familiar 8F.";

        Keywords.Add("London Midland and Scottish Railway");
        Keywords.Add("class 8F");
        Keywords.Add("hauling heavy freight");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("48305"),
            new LocoDetails("48773"),
            new LocoDetails("600", "GORDON"),
            });
    }
}