using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class NormanColliery : LayoutBase
    {
        public NormanColliery()
        {
            Name = LayoutNamesEnums.NormanColliery;
            Gauge = Gauges.O_Gauge;
            Owner = "Geoff Brain";
            Description = "Norman Colliery was born out of the need to have somewhere to shove wagons about with my\r\ncollection of early diesel shunters. The premise is that the colliery is at the end of its life with only\r\nthe top screens in use. The only problem is that the feeder road to the upper screens has been\r\nclosed by subsidence so a link line had to be made to the lower line giving a multi level layout.";
        }
    }
}