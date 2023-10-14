using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore._SiteData.LocoRefs.Steam;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonBrakevan20T : WagonsClassBase
    {
        public WagonBrakevan20T()
        {
            ClassName = "Brakevan 20T";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B954546" ),
                });
        }
    }
}