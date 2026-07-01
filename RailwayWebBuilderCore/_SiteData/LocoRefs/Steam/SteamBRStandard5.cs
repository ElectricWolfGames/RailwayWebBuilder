using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamBRStandard5 : SteamClassBase
{
    public SteamBRStandard5()
    {
        ClassName = "BR Standard 5";
        StockType = StockTypes.SteamLoco;

        Designer = "Robert Riddles";
        Builder = "BR Derby Works, BR Doncaster Works";
        BuildDate = "1951–1957";
        TotalProduced = 172;
        WhyteNotation = "4-6-0";
        Cylinders = "2 × 19 in × 28 in";
        BoilerPressure = "225 psi";
        DriverWheelDia = "6 ft 2 in";
        LeadingWheelDia = "3 ft 0 in";
        LocoWeight = "76 tons 5 cwt";
        TenderWeight = "49 tons 3 cwt";
        Length = "63 ft 5½ in";
        MaxSpeed = "90 mph";
        TractiveEffort = "26,120 lbf";

        Paragraph1 = "The British Railways Standard Class 5MT 4-6-0 was one of the 12 standard classes of steam locomotive built by British Railways in the 1950s." +
                   "It was essentially a development of the LMS Stanier Class 5 4-6-0 ('Black Five'). A total of 172 were built between 1951 and 1957.";
        Paragraph2 = "William Stanier's Black Five had been the most successful mixed-traffic type in Great Britain." +
            "Construction of the Black Fives had started in 1934 and continued past nationalisation to 1951. " +
            "A new set of 'standard' locomotives was to be built by British Railways, based on LMS designs and incorporating modern ideas.";

        Keywords.Add("BR Standard Class 5");
        Keywords.Add("class 5");
        Keywords.Add("1960");
        Keywords.Add("Robert Riddles");
        Keywords.Add("4-6-0");
        Keywords.Add("73156");
        Keywords.Add("73082");
        Keywords.Add("Camelot");
        Keywords.Add("British Railways");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("73156"),
            new LocoDetails("73082", "Camelot"),
            });
    }
}