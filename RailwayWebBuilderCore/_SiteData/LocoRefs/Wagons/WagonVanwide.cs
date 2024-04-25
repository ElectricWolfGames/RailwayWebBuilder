using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonVanwide : WagonsClassBase
    {
        public WagonVanwide()
        {
            ClassName = "Vanwide";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            Paragraph1 = "12T, Built in Derby, Type Vanwide, Wheelbase 10ft, TOPS VEB";
            //Built = "Derby";
            //Wheelbase = "10ft";
            //Diagram number 1/217

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("B783082" ),
                new LocoDetails("B784409" ),
                new LocoDetails("B783082" ),
                });
        }
    }
}