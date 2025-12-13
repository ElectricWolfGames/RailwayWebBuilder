using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonWeltrol : WagonsClassBase
{
    public WagonWeltrol()
    {
        ClassName = "Weltrol";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("M300356" ),
            });
    }
}