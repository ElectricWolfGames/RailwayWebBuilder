using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class SanClemente : LayoutBase, ILayoutByLayoutSetB
{
    public SanClemente()
    {
        Name = LayoutNamesEnums.SanClemente;
        Owner = "N. Palette";
        Description = "San Clemente is set in the late 1950s and portrays a branch line operation in Southern California. It is served by the Santa Fe and Southern Pacific railroads. Traffic is mainly agricultural products in reefers (refrigerated cars).";
    }
}