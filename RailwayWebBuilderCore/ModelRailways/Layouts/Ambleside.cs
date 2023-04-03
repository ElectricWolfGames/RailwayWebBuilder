using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class Ambleside : LayoutBase
    {
        public Ambleside()
        {
            Name = LayoutNames.Ambleside;
            Gauge = Gauges.OO_Gauge;
            Owner = "The Elizabethan Railway Society";
            Description = "Pre-grouping through station serving two branch lines. If the Kendal and Windermere Railway " +
                "company had fulfilled their plans, then Ambleside would have been a junction between Keswick and " +
                "Penrith.";
        }
    }
}