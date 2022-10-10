using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class BrittanniaMills : LayoutBase
    {
        public BrittanniaMills()
        {
            Name = LayoutNames.BrittanniaMills;
            Gauge = Gauges.OO_Gauge;
            Owner = "Jay Sanders";
            Description = "Brittannia Mills were built in 1902 for Samual Bournce & Co. Ltd. " +
                "In Netherfield east of Nottingham. Located alongside the GNR, Nottingham to Grantham railway line and next to Netherfield and Cowlick railway Station.";
        }
    }
}