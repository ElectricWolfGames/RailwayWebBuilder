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
            Description = "The layout is based on a fictional location in the eastern part of the Baltic Sea now part of Poland. " +
                "The Structures on the layout are mainly modelled on the Koenigsberg in the former east Prussia area. " +
                "The trains are a mixture of KPEV and DRG and are reflection prototypes seen in the area.";
        }
    }
}