using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class Brunshafen : LayoutBase
    {
        public Brunshafen()
        {
            Name = LayoutNames.Brunshafen;
            Gauge = Gauges.HO_Gauge;
            Owner = "Axel Klozenbeucher";
            Description = "The layout is based on a fictional location in the eastern part of the Baltic Sea now part of Poland.\r\nThe structures on the layout are mainly modelled on Koenigsberg in the former East Prussia area.\r\nThe trains are a mixture of KPEV and DRG and are reflecting prototypes seen in the area.";
        }
    }
}