using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamLNERJ27 : SteamClassBase
{
    public SteamLNERJ27()
    {
        ClassName = "LNER J27, NER Class P3";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The North Eastern Railway (NER) Class P3, classified J27 by the LNER, is a class of 0-6-0 steam locomotive. The P3 Class was designed by Wilson Worsdell and was a relatively minor modification of the existing North Eastern Railway Class P2 (LNER Class J26). The most significant change was a deeper firebox with shallower sloping fire grate. This was achieved by raising the boiler slightly, and by reducing the clearance between the firebox and the rear axle. The P3 Class were a freight engine by nature and used for hauling long trains of freight.";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("65894"),
            });
    }
}