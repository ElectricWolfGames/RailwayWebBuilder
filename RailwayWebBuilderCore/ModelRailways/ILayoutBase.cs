using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways
{
    internal interface ILayoutBase
    {
        string Description { get; set; }
        string Group { get; set; }
        LayoutNamesEnums Name { get; set; }
        string Owner { get; set; }
    }
}