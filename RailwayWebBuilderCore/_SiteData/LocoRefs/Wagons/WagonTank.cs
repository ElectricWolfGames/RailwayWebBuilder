using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore._SiteData.LocoRefs.Steam;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonTank : WagonsClassBase
    {
        public WagonTank()
        {
            ClassName = "Tank";
            StockType = StockTypes.Wagon;
            Paragraph1 = "Tank, 32T Tank Built by Charles Roberts & Co 1965, Wheelbase 15ft, TOPS TTB";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("1408" ),
                new LocoDetails("3436" ),
                new LocoDetails("3711" ),
                new LocoDetails("5209" ),
                new LocoDetails("VTG60874" ),
                new LocoDetails("VTG60879" ),
                });
        }
    }
}