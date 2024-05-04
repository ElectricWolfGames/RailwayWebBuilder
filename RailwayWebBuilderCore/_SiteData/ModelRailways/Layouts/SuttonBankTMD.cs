using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class SuttonBankTMD : LayoutBase, ILayoutByLayout
    {
        public SuttonBankTMD()
        {
            Name = LayoutNamesEnums.SuttonBankTMD;
            Description = "Sutton Bank TMD modern small depot layout with 3 sidings shed road and " +
                "low-level siding. Stock ranging from Early 2000s to present day";
            LayoutByLayoutVideo = "";
        }
    }
}