using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class NoPlace : LayoutBase
    {
        public NoPlace()
        {
            Name = LayoutNamesEnums.NoPlace;
            Owner = "";
            Description = "";  // TODO NoPlace Needs description 
        }
    }
}