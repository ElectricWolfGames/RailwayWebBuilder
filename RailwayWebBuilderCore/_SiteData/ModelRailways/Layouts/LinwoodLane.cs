using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class LinwoodLane : LayoutBase, ILayoutByLayout
    {
        public LinwoodLane()
        {
            Name = LayoutNamesEnums.LinwoodLane;

            Owner = "Shaun Greet";
            Description = "Linwood Lane an East Anglian branch during the 1960s. Serving a local station, little coal depot and a busy goods yard. Traffic is varied, freight is busy and hauled by class 15 /24/31 and passengers in the hands of various DMUs. The Scenic section is 4ft long to show what can be achieved. All items are readily available and modified in a suitable way.";
            LayoutByLayoutVideo = "";
        }
    }
}