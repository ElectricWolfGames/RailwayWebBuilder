using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class EuDepot : LayoutBase, ILayoutByLayout
    {
        public EuDepot()
        {
            Name = LayoutNamesEnums.EuDepot;
            Owner = "";
            Description = "";  // TODO EuDepot Needs description
        }
    }
}