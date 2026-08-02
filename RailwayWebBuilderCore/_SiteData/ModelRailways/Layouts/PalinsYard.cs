using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class PalinsYard : LayoutBase
{
    public PalinsYard()
    {
        Name = LayoutNamesEnums.PalinsYard;
        Owner = "Peter Lloyd";
        Description = "Based on a Gordon Gravett shed design from Volume 2 of his 7mm Modelling books, built on internal doors as baseboards, with small industrial 0-4-0 locomotives (mainly Ixion Fowler and Minerva Peckett types), hand-built Peco-based track, and ZTC DCC control with Minx Microdrive point motors. It is named for the palindromic lettering (A, H, I, M, O, T, V, W, X, Y) needed so mirror-reflected signage would still read correctly, used to make the small layout feel larger.";
    }
}
