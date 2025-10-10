using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class Wagon_Medfit : WagonsClassBase
{
    public Wagon_Medfit()
    {
        ClassName = "Medfit";
        StockType = StockTypes.Wagon;

        Paragraph1 = "";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("B458484" ),
            new LocoDetails("B461074" ),
            new LocoDetails("M477031" ),
            });
    }
}