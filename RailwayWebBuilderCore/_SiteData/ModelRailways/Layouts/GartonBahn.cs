using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class GartonBahn : LayoutBase
{
    public GartonBahn()
    {
        Name = LayoutNamesEnums.GartonBahn;
        Owner = "C. Green";
        Description = "A G gauge layout based in Austria.";
    }
}