using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Wagons;

public class Wagon100TBogieTank : WagonsClassBase
{
    public Wagon100TBogieTank()
    {
        ClassName = "TEA 100t Bogie Tank";
        StockType = StockTypes.Wagon;
        Paragraph1 = "TEA 4099 was built in 1967 by R Y Pickering company of Wishaw, near Glasgow. Other Numbers it has carried are 83088 and 87483. Wagon awaiting restoration by the Quorn Wagon & Wagon Group at the GCR.";
        Builder = "R Y Pickering & Co, Wishaw";
        BuildDate = "1967";
        LoadCapacity = "100T";

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("VTG87483" ),
            });
    }
}