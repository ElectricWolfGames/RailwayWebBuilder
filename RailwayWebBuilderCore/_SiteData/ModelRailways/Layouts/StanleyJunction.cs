using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class StanleyJunction : LayoutBase
{
    public StanleyJunction()
    {
        Name = LayoutNamesEnums.StanleyJunction;
        Owner = "East Kilbride MRC";
        Description = "Depicts the real Stanley Junction, around 8 miles north of Perth on the Caledonian main line to Aberdeen via Forfar, where the Highland Railway's line to Inverness began. It shows the unusual track layout before partial closure in 1967, when the Forfar section became freight-only, researched using archive maps and materials plus a site visit.";
    }
}
