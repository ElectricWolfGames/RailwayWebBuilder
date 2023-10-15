using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonShochigh : WagonsClassBase
    {
        public WagonShochigh()
        {
            ClassName = "Shochigh";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B724570" ),
                });
        }
    }
}