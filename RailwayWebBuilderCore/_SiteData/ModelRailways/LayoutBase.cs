using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore._SiteData.ModelRailways
{
    internal class LayoutBase : ILayoutBase
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public LayoutNamesEnums Name { get; set; }
        public string Owner { get; set; }
    }
}