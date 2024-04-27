using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Burdock : LayoutBase, ILayoutByLayout
    {
        public Burdock()
        {
            Name = LayoutNamesEnums.Burdock;

            Owner = "Dave Westwood";
            Description = "Although fictional, is an attempt to capture the flavour of the Golden Valley line between Stroud and Swindon.  The period is Summer 1964 and traffic is typical of that period, although various motive power oddities may appear, so be prepared for surprises!";
        }
    }
}