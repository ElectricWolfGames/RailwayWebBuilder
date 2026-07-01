using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamWestCountryClass : SteamClassBase
{
    public SteamWestCountryClass()
    {
        ClassName = "West Country Class";
        StockType = StockTypes.SteamLoco;

        Designer = "Oliver Bulleid";
        Builder = "Eastleigh Works, Brighton Works";
        BuildDate = "1945–1950";
        TotalProduced = 66;
        WhyteNotation = "4-6-2";
        Cylinders = "3 × 16¼ in × 24 in";
        BoilerPressure = "280 psi";
        DriverWheelDia = "6 ft 2 in";
        LeadingWheelDia = "3 ft 1 in";
        LocoWeight = "86 tons 0 cwt";
        TenderWeight = "42 tons 12 cwt";
        Length = "67 ft 4⅞ in";
        MaxSpeed = "106 mph";
        TractiveEffort = "31,046 lbf";

        Paragraph1 = "The SR West Country and Battle of Britain classes, collectively known as Light Pacifics or informally as Spam Cans, " +
            "are air-smoothed 4-6-2 Pacific steam locomotives designed for the Southern Railway by its Chief Mechanical Engineer Oliver Bulleid. " +
            "Incorporating a number of new developments in British steam locomotive technology, they were amongst the first British designs to use " +
            "welding in the construction process, and to use steel fireboxes, which meant that components could be more easily constructed under wartime " +
            "austerity and post-war economy";

        Keywords.Add("TamValley");
        Keywords.Add("4-6-2");
        Keywords.Add("West Country Class");
        Keywords.Add("Oliver Bulleid");
        Keywords.Add("Southern Railway");
        Keywords.Add("SR");
        Keywords.Add("Light Pacific");
        Keywords.Add("Spam Can");
        Keywords.Add("21C127");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("21C127", "TamValley"),
            });
    }
}