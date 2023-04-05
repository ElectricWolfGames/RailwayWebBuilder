using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal interface ILayoutBase
    {
        string Description { get; set; }
        Gauges Gauge { get; set; }
        string Group { get; set; }
        LayoutNamesEnums Name { get; set; }
        string Owner { get; set; }
    }

    internal class LayoutBase : ILayoutBase
    {
        public string Description { get; set; }
        public Gauges Gauge { get; set; }// can remove this
        public string Group { get; set; }
        public LayoutNamesEnums Name { get; set; }
        public string Owner { get; set; }
    }
}