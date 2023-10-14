using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore._SiteData.LocoRefs.Steam;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonShocbar : WagonsClassBase
    {
        public WagonShocbar()
        {
            ClassName = "Shocbar";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B721587" ),
                });
        }
    }
}