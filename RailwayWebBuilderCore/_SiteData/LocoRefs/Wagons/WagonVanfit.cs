using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore._SiteData.LocoRefs.Steam;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class WagonVanfit : WagonsClassBase
    {
        public WagonVanfit()
        {
            ClassName = "Vanfit";
            StockType = StockTypes.Wagon;

            Paragraph1 = "";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("M500954" ),
                new LocoDetails("B762855" ),
                new LocoDetails("B763305" ),
                new LocoDetails("B765272" ),
                new LocoDetails("B777171" ),
                new LocoDetails("B777728" ),
                new LocoDetails("B779978" ),
                new LocoDetails("B780282" ),
                new LocoDetails("B786181" ),
                new LocoDetails("B786348" ),
                });
        }
    }
}