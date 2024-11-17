using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class ShawbridgeJunction : LayoutBase, ILayoutByLayoutSetA
    {
        public ShawbridgeJunction()
        {
            Name = LayoutNamesEnums.ShawbridgeJunction;
            Owner = "The Elizabethan Society";
            Description = "";
            LayoutByLayoutVideo = "";
        }
    }
}