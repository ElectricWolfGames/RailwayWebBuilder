using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class FrantonMill : LayoutBase
{
    public FrantonMill()
    {
        Name = LayoutNamesEnums.FrantonMill;
        Owner = "M. Denton";
        Description = "An industrial shunting layout connected to the main line about a mile away. A disused cotton mill, purchased by \"Franton Brothers\" to provide a plaster manufacturing facility for their nearby gypsum mines, is linked to the main line by extensive exchange sidings.";
    }
}