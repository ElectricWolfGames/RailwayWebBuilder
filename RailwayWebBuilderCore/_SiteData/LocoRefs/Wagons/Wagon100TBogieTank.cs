using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons
{
    public class Wagon100TBogieTank : WagonsClassBase
    {
        public Wagon100TBogieTank()
        {
            ClassName = "TEA 100t Bogie Tank";
            StockType = StockTypes.Wagon;
            Paragraph1 = "TEA 4099 was built in 1967 by R Y Pickering company of Wishaw, near Glasgow. Other Numbers it has carried are 83088 and 87483. Wagon awaiting restoration by the Quorn Wagon & Wagon Group at the GCR.";

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("VTG87483" ),
                });
        }
    }
}