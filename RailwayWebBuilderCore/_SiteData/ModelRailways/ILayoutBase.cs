using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways
{
    internal interface ILayoutBase
    {
        string Description { get; set; }
        LayoutNamesEnums Name { get; set; }
        string Owner { get; set; }
    }
}