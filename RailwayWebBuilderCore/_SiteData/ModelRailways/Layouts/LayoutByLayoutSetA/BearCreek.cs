using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts.LayoutByLayoutSetA
{
    internal class BearCreek : LayoutBase, ILayoutByLayoutSetA
    {
        public BearCreek()
        {
            Name = LayoutNamesEnums.BearCreek;
            Owner = "";
            Description = ""; // TODO
            LayoutByLayoutVideo = "";
        }
    }
}