using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class CookEnd : LayoutBase, ILayoutByLayoutSetB
    {
        public CookEnd()
        {
            Name = LayoutNamesEnums.CookEnd;

            Owner = "LMRG";
            Description = "The layout is based upon the Haverhill station on the Colne Valley and Halstead Railway, 1863 - 1965. The station was opened as the northern terminus of the CVLR with prospects of extending to Cambridge. In 1865 the GE railway opened its Cambridge to Sudbury line with a connecting spur to the CVLR. </br></br>" +
                " In 1924 the passenger service was diverted to the GER station, although we still run workman trains and specials to the station.";
        }
    }
}