using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLNERJ27 : SteamClassBase
{
    public SteamLNERJ27()
    {
        ClassName = "LNER J27, NER Class P3";
        StockType = StockTypes.SteamLoco;

        Designer = "Wilson Worsdell";
        Builder = "Darlington Works, North British Locomotive Co";
        BuildDate = "1906–1923";
        TotalProduced = 115;
        WhyteNotation = "0-6-0";
        Cylinders = "2 × 18½ in × 26 in";
        BoilerPressure = "180 psi";
        DriverWheelDia = "5 ft 6 in";
        LocoWeight = "43 tons 0 cwt";
        TenderWeight = "38 tons 0 cwt";
        Length = "51 ft 8 in";
        MaxSpeed = "50 mph";
        TractiveEffort = "21,905 lbf";

        Paragraph1 = "The North Eastern Railway (NER) Class P3, classified J27 by the LNER, is a class of 0-6-0 steam locomotive. The P3 Class was designed by Wilson Worsdell and was a relatively minor modification of the existing North Eastern Railway Class P2 (LNER Class J26). The most significant change was a deeper firebox with shallower sloping fire grate. This was achieved by raising the boiler slightly, and by reducing the clearance between the firebox and the rear axle. The P3 Class were a freight engine by nature and used for hauling long trains of freight.";

        Keywords.Add("LNER J27");
        Keywords.Add("NER P3");
        Keywords.Add("Wilson Worsdell");
        Keywords.Add("0-6-0");
        Keywords.Add("freight");
        Keywords.Add("North Eastern Railway");
        Keywords.Add("65894");
        Keywords.Add("LNER");
        Keywords.Add("NER");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("65894"),
            });
    }
}