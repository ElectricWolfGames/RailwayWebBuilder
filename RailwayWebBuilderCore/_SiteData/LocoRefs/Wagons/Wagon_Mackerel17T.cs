using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonMackerel17T : WagonsClassBase
    {
        public WagonMackerel17T()
        {
            ClassName = "Mackerel 17 Ton";
            StockType = StockTypes.Wagon;

            Paragraph1 = "Mackerel 17 ton Ballast Hopper Wagon";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("DB992358" ),
                });
        }
    }
}