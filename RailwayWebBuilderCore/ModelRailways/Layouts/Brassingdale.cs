using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class Brassingdale : LayoutBase
    {
        public Brassingdale()
        {
            Name = LayoutNamesEnums.Brassingdale;
            Gauge = Gauges.N_Gauge;
            Owner = "Roger Wright";
            Description = "Brassingdale is a fictitious location somewhere between Brassington and Wirksworth in Derbyshire. " +
                "Set in the mid thirties, the town has grown from a small hamlet serving the local limestone quarries " +
                "to a large town with its own station. The two main lines on the embankment represent one of the " +
                "many lines crossing the dales and serving larger towns like Buxton.";
        }
    }
}