using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class OilDrumLane : LayoutBase
{
    public OilDrumLane()
    {
        Name = LayoutNamesEnums.OilDrumLane;
        Owner = "";
        Description = "A fictitious DRS depot located somewhere in the northern suburbs of London. The depot consists of a four track MPD for daily routine servicing tasks, together with locomotive refuelling and DRS crew signing on facilities. The layout is operated by DCC using NCE, and the locomotives are all sound fitted and weathered, some cleaner than others. Yard and building lighting adds to the effect of this DRS MPD.";
    }
}