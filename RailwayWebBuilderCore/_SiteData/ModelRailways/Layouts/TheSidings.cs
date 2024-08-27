using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class TheSidings : LayoutBase, ILayoutByLayout
    {
        public TheSidings()
        {
            Name = LayoutNamesEnums.TheSidings;
            Owner = "";
            Description = "";  // TODO TheSidings Needs description
        }
    }
}