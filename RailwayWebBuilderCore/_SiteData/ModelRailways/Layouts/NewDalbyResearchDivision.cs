using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class NewDalbyResearchDivision : LayoutBase, ILayoutByLayout
    {
        public NewDalbyResearchDivision()
        {
            Name = LayoutNamesEnums.NewDalbyResearchDivision;
            Owner = "Andrew Porter";
            Description = ""; // TODO NewDalbyResearchDivision Needs description
            LayoutByLayoutVideo = "https://youtu.be/Kcrtbzv7rd4";
        }
    }
}