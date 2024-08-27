using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class LittlePointWharf : LayoutBase, ILayoutByLayout
    {
        public LittlePointWharf()
        {
            Name = LayoutNamesEnums.LittlePointWharf;

            Owner = "Tim & Matt Stevens";
            Description = "A micro-layout of a dockside/wharf area “somewhere in England” in the 1980s.  It was built relatively cheaply and quickly as a “fun” shunting layout.  Points are hand operated using under-board rodding.  The name comes from a former exhibition micro-layout that Matt’s father, Tim, built around twenty years ago.";
        }
    }
}