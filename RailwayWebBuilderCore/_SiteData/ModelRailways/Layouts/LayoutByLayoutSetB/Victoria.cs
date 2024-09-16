using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Victoria : LayoutBase, ILayoutByLayoutSetB
    {
        public Victoria()
        {
            Name = LayoutNamesEnums.Victoria;
            Owner = "Dave Tailby";
            Description = "Parcels platforms based on Victoria Station in Central London handling mainly parcels and sundries traffic, though the occasional passenger train diverted from a main platform. EM gauge is the same 1:76 as OO but is 1.5mm wider between the rails at 18mm";
        }
    }
}