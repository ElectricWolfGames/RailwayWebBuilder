using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Brunshafen : LayoutBase
    {
        public Brunshafen()
        {
            Name = LayoutNamesEnums.Brunshafen;
            Owner = "Axel Klozenbeucher";
            Description = "The layout is based on a fictional location in the eastern part of the Baltic Sea now part of Poland. " +
                "The structures on the layout are mainly modelled on Koenigsberg in the former East Prussia area. " +
                "The trains are a mixture of KPEV and DRG and are reflecting prototypes seen in the area.";
        }
    }
}