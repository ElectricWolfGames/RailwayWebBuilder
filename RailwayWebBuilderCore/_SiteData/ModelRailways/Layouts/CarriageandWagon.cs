using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class CarriageandWagon : LayoutBase
    {
        public CarriageandWagon()
        {
            Name = LayoutNamesEnums.CarriageandWagon;
            Owner = "";
            Description = "";  // TODO CarriageandWagon Needs description
        }
    }
}