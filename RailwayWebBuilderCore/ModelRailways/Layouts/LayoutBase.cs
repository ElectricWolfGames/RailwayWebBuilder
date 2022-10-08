using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class LayoutBase
    {
        public string Description { get; set; }
        public Gauges Gauge { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
    }
}