using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class BearCreek : LayoutBase, ILayoutByLayout
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