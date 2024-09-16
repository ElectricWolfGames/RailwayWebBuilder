using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Oscarton : LayoutBase, ILayoutByLayoutSetB
    {
        public Oscarton()
        {
            Name = LayoutNamesEnums.Oscarton;
            Owner = "Robin Sharman";
            Description = "Oscarton station is a four platform terminus served exclusively by DMUs, and has working colour " +
                "light signals positioned at the platform ends. The track plan comprises two interwoven shuttle " +
                "lines - one automatic and the other manually controlled.";
        }
    }
}