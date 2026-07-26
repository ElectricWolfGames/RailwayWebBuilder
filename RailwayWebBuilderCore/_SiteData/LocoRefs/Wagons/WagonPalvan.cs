using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonPalvan : WagonsClassBase
{
    public WagonPalvan()
    {
        ClassName = "Palvan";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "BR Darlington";
        BuildDate = "1955-1959";
        Diagram = "1/211";
        Wheelbase = "10ft";
        TareWeight = "12T";
        BrakeType = "Vacuum-braked";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B781908" ),
            new LocoDetails("WGB 4019" ),
            new LocoDetails("WGB 4042" ),
            });
    }
}