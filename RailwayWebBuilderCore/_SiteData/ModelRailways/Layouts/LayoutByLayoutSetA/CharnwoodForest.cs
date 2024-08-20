using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class CharnwoodForest : LayoutBase, ILayoutByLayoutSetA
    {
        public CharnwoodForest()
        {
            Name = LayoutNamesEnums.CharnwoodForest;
            Owner = "SVMRC";
            Description = "The O gauge layout started with the original idea showcasing the Charnwood Forest Line Loughborough Derby Road Station which led out to a viaduct in a straight up and down configuration. After a lot of thought and with the hope of doing something different we decided that although the LMNW line closed to passenger traffic in 1931 we tried to envisage what it would have been like in the late 1950s early 1960s if the line had remained opened.  Our original idea was developed and with much discussion it was decided that the layout should increase in size and that it would contain 4 major view points, a) Loughborough Derby Road Station would remain but would now include a goods shed,turn table and M.P.D. b) Whitwick Station would now be included with an additional platform to allow passing passenger trains (this was included for running and interest purposes). c) a goods yard with the appropriate goods loading dock, d) Grace Dieu Viaduct with its intricate stone and brick work leading through a bridge into the fiddle yard.";
            LayoutByLayoutVideo = "";
        }
    }
}