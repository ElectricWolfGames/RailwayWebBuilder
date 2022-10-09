using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class NormanColliery : LayoutBase
    {
        public NormanColliery()
        {
            Name = LayoutNames.NormanColliery;
            Gauge = Gauges.O_Gauge;
            Owner = "Geoff Brain";
            Description = "Norman Colliery was born out of the need to have somewhere to shove wagons about with my collection of early diesel shunters. " +
                "The premise is that the colliery is at the end of its life with only the top screen in sue. " +
                "The only problem is that the feeder road to the upper screen has been closed by subsidence so a link line had to be made to the lower line giving a multi level layout.";
        }
    }
}