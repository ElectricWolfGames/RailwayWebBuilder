using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonBogieBolster : WagonsClassBase
    {
        public WagonBogieBolster()
        {
            ClassName = "Bogie Bolster";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B928135" ),
                });
        }
    }
}