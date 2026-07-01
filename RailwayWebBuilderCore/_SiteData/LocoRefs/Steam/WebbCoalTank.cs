using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class WebbCoalTank : SteamClassBase
{
    public WebbCoalTank()
    {
        ClassName = "Webb Coal Tank (LNWR)";
        StockType = StockTypes.SteamLoco;

        Designer = "F. W. Webb";
        Builder = "LNWR Crewe Works";
        BuildDate = "1881–1897";
        TotalProduced = 300;
        WhyteNotation = "0-6-2T";
        Cylinders = "2 × 17 in × 24 in";
        BoilerPressure = "150 psi";
        DriverWheelDia = "5 ft 0 in";
        LeadingWheelDia = "3 ft 3½ in";
        LocoWeight = "44 tons 0 cwt";
        Length = "35 ft 6 in";
        MaxSpeed = "50 mph";
        TractiveEffort = "14,200 lbf";

        Paragraph1 = "The London and North Western Railway (LNWR) Webb Coal Tank is a class of 0-6-2T steam locomotive. They were called 'Coal Tanks' because they were a side tank version of Webb's standard LNWR 17in Coal Engine, an 0-6-0 tender engine for slow freight trains.";
        Paragraph2 = "The design was introduced in 1881 by F.W. Webb and had the same cheaply produced cast iron wheels and H-section spokes as the tender engines. A trailing radial axle supporting the bunker was added also with two similarly cast iron wheels. Three hundred were built between 1881 and 1897.";

        Keywords.Add("Webb Coal Tank");
        Keywords.Add("1054");
        Keywords.Add("LNWR");
        Keywords.Add("F. W. Webb");
        Keywords.Add("London and North Western Railway");
        Keywords.Add("0-6-2T");
        Keywords.Add("steam locomotive");
        Keywords.Add("preserved steam");
        Keywords.Add("locomotive photo");
        Keywords.Add("heritage railway");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("1054"),
            });
    }
}