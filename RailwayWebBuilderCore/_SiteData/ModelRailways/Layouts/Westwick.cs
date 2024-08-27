using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Westwick : LayoutBase, ILayoutByLayout
    {
        public Westwick()
        {
            Name = LayoutNamesEnums.Westwick;
            Owner = "Westwick MRC";
            Description = ""; // TODO Westwick Needs description
        }
    }
}