using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class UptonWhent : LayoutBase, ILayoutByLayout
    {
        public UptonWhent()
        {
            Name = LayoutNamesEnums.UptonWhent;
            Owner = "";
            Description = "Come and have a good look round our 00 Gauge layout and enjoy the trains and scenery. ";
        }
    }
}