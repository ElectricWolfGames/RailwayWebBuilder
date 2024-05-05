using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class QuarryEnd : LayoutBase, ILayoutByLayout
    {
        public QuarryEnd()
        {
            Name = LayoutNamesEnums.QuarryEnd;

            Description = "Quarry end is a small village set somewhere in Wales where most of the people work at the local slateimine. Questions are welcome at all times.";
            LayoutByLayoutVideo = "";
        }
    }
}