using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class WagonPipe : WagonsClassBase
{
    public WagonPipe()
    {
        ClassName = "Pipe";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";
        Builder = "Derby, Cambrian, Swindon, Wolverton & Darlington Works";
        Diagram = "1/460-1/463 (TOPS SOV, later ZDV/ZGV/ZRV/ZSP)";
        Wheelbase = "12ft";
        LoadCapacity = "12T";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B740654" ),
            });
    }
}