using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Torreycombe : LayoutBase, ILayoutByLayoutSetB
    {
        public Torreycombe()
        {
            Name = LayoutNamesEnums.Torreycombe;
            Owner = "";
            Description = "Torreycombe is a fictional station set in North Devon, The line is now freight\r\nonly before kept open for the dairy that is situated on the station site. The\r\ndairy itself has been extended since the station closed to passengers and\r\nnow occupies much of the goods yards. It’s is set in mid to late 50's/Early\r\n60's and can see traffic from both Weston and southern regions.";
        }
    }
}