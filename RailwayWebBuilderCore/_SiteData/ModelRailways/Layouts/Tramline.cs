using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class Tramline : LayoutBase
{
    public Tramline()
    {
        Name = LayoutNamesEnums.Tramline;
        Owner = "";
        Description = "";  // TODO Tramline Needs description
    }
}