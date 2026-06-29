using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLMSStanier8F : SteamClassBase
{
    public SteamLMSStanier8F()
    {
        ClassName = "LMS Stanier 8F Class";
        StockType = StockTypes.SteamLoco;

        Designer = "William Stanier";
        Builder = "Crewe Works, Darlington Works, Doncaster Works, Eastleigh Works, Horwich Works, Swindon Works, Vulcan Foundry";
        BuildDate = "1935–1946";
        TotalProduced = 852;
        WhyteNotation = "2-8-0";
        Cylinders = "2 × 18½ in × 28 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "4 ft 8½ in";
        LeadingWheelDia = "3 ft 3½ in";
        LocoWeight = "72 tons 2 cwt";
        TenderWeight = "54 tons 12 cwt";
        Length = "63 ft 9 in";
        MaxSpeed = "60 mph";
        TractiveEffort = "32,438 lbf";
        WikiLink = "https://en.wikipedia.org/wiki/LMS_Stanier_Class_8F";

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