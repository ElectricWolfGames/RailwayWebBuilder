using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class GlenadamDistillery : LayoutBase, ILayoutByLayoutSetB
    {
        public GlenadamDistillery()
        {
            Name = LayoutNamesEnums.GlenadamDistillery;
            Owner = "";
            Description = "Glenadam Distillery is a oo gauge micro layout based on a fictitious whisky distillery in Scotland. The Layout has been built by its operator Adam Miles, who was inspired by the Scotch whisky rail traffic of the early ig6os to cre-ate this bygone era in a small shunting layout with a scenic area. See Scot-tish allocated British Railway locomotives deliver wagon loads of coal, casks & grain to the distillery for the distillery's own locomotives to Marshall";
        }
    }
}