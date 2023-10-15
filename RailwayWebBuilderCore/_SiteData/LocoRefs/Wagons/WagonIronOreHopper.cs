using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonIronOreHopper : WagonsClassBase
    {
        public WagonIronOreHopper()
        {
            ClassName = "Iron Ore Hopper";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B439708" ),
                });
        }
    }
}