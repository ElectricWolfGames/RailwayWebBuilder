using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class EuDepot : LayoutBase, ILayoutByLayoutSetB
{
    public EuDepot()
    {
        Name = LayoutNamesEnums.EuDepot;
        Owner = "";
        Description = "";
    }
}