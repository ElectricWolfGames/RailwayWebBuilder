using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonConflat : WagonsClassBase
    {
        public WagonConflat()
        {
            ClassName = "Conflat";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B505313" ),
                new LocoDetails("B507489" ),
                });
        }
    }
}