using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class KnotLittlefield : LayoutBase, ILayoutByLayout
    {
        public KnotLittlefield()
        {
            Name = LayoutNamesEnums.KnotLittlefield;
            Owner = "";
            Description = "";  // TODO KnotLittlefield Needs description
        }
    }
}