using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselBRDerbyLightweight : DieselClassBase
    {
        public DieselBRDerbyLightweight()
        {
            ClassName = "Derby Lightweight";
            StockType = StockTypes.Diesel;

            Paragraph1 = "The British Rail Derby Lightweight diesel multiple units, were the first such trains to be built en-masse for British Railways. The units were built at BR's Derby Works from 1954 to 1955. The units were built in various formations, including 12 power-twin 2-car units, 84 power-trailer 2-car units, and four 4-car units. The two single car units were originally built as a two-car unit and then split two years later when demand came about.";
            Paragraph2 = "Body framing was extruded and riveted together. Panelling was welded into continuous sheets and riveted to the frame. Luggage racks were light alloy. The floors had 2 layers of flameproof hardboard, covered with linoleum. To reduce noise and condensation, the inside structure and undersides were sprayed with asbestos. Lighting was by 60-watt, 24-volt lamps charged by belt driven dynamos. Heating was oil fired. Standard mild steel bogies ran on Timken roller bearings.";
            Paragraph3 = "Contemporaneous with these units was the unique Battery Electric Multiple Unit.";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("M79900", "Iris"),
                });
        }
    }
}