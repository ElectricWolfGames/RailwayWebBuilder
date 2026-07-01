using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamBRStandard2 : SteamClassBase
{
    public SteamBRStandard2()
    {
        ClassName = "BR Standard 2";
        StockType = StockTypes.SteamLoco;

        Designer = "Robert Riddles";
        Builder = "BR Darlington Works, BR Swindon Works";
        BuildDate = "1952–1956";
        TotalProduced = 65;
        WhyteNotation = "2-6-0";
        Cylinders = "2 × 16½ in × 24 in";
        BoilerPressure = "200 psi";
        DriverWheelDia = "5 ft 0 in";
        LeadingWheelDia = "3 ft 0 in";
        LocoWeight = "49 tons 0 cwt";
        TenderWeight = "42 tons 3 cwt";
        Length = "57 ft 11¼ in";
        MaxSpeed = "65 mph";
        TractiveEffort = "18,515 lbf";

        Paragraph1 = "The BR Standard Class 2 2-6-0 is a class of steam locomotive, one of the British Railways Standard classes of the 1950s. They were physically the smallest of the Standard classes";
        Paragraph2 = "65 were built";

        Keywords.Add("BR Standard Class 2");
        Keywords.Add("class 2");
        Keywords.Add("Robert Riddles");
        Keywords.Add("2-6-0");
        Keywords.Add("78018");
        Keywords.Add("78019");
        Keywords.Add("British Railways");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("78018"),
            new LocoDetails("78019"),
            });
    }
}