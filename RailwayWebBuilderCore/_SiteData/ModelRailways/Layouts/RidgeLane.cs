using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class RidgeLane : LayoutBase
{
    public RidgeLane()
    {
        Name = LayoutNamesEnums.RidgeLane;
        Owner = "Ben Powell";
        Description = "Ridge Lane is an exchange area where loaded mineral wagons from a quarry are handed over to larger locomotives for the transhipment wharf on the LMS main line. Small 4- and 6-coupled engines work the quarry line, while larger 6-coupled engines work the main line. The station at Ridge Lane, once a hopeful enterprise, is now seldom used.";
    }
}