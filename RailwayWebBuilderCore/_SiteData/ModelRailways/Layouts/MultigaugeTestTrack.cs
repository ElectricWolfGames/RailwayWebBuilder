using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class MultigaugeTestTrack : LayoutBase
{
    public MultigaugeTestTrack()
    {
        Name = LayoutNamesEnums.MultigaugeTestTrack;
        Owner = "Northampton MRC";
        Description = "A multi-gauge test-track layout with seven oval circuits - three outer O gauge circuits and four inner OO gauge circuits - where visitors can have a newly bought locomotive tested. The O gauge circuits support both DCC and analogue control; the OO gauge circuits are analogue only, subject to change.";
    }
}
