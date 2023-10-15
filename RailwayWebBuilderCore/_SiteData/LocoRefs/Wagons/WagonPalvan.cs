using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonPalvan : WagonsClassBase
    {
        public WagonPalvan()
        {
            ClassName = "Palvan";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B781908" ),
                new LocoDetails("WGB 4019" ),
                new LocoDetails("WGB 4042" ),
                });
        }
    }
}