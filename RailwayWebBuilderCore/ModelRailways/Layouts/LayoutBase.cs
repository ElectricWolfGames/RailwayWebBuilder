using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal interface ILayoutBase
    {
        string Description { get; set; }
        Gauges Gauge { get; set; }
        string Group { get; set; }
        string Name { get; set; }
        string Owner { get; set; }
    }

    internal class LayoutBase : ILayoutBase
    {
        public string Description { get; set; }
        public Gauges Gauge { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
    }
}