using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class StMichaelsVale : LayoutBase
    {
        public StMichaelsVale()
        {
            Name = LayoutNames.StMichaelsVale;
            Gauge = Gauges.N_Gauge;
            Owner = "The Elizabethan Railway Society";
            Description = "This layout is the results of the purchase of an old and tired layout by one of our members. " +
                "We have put in many hours of work to get it to this point and although it is still an ongoing project we decided it had progressed far enough to exhibit in this year's show";
        }
    }
}