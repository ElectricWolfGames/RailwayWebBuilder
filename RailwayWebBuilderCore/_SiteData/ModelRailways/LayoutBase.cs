using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways
{
    internal class LayoutBase : ILayoutBase
    {
        public string Description { get; set; }

        public string LayoutByLayoutVideo { get; set; }
        public LayoutNamesEnums Name { get; set; }
        public string Owner { get; set; }
    }
}