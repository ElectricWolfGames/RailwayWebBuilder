using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class FredstoneLane : LayoutBase
{
    public FredstoneLane()
    {
        Name = LayoutNamesEnums.FredstoneLane;
        Owner = "Alsager RA";
        Description = "Named in memory of Fred Johnson, well known on the railway circuit. The layout has inner and outer circuits at different levels with crossovers and reversing loops, separate passenger and freight tracks, a freight marshalling yard offering shunting opportunities at one end, and a running water feature at the other.";
    }
}