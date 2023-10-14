using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore._SiteData.LocoRefs.Steam;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonMinfit : WagonsClassBase
    {
        public WagonMinfit()
        {
            ClassName = "Minfit";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B550356" ),
                });
        }
    }
}