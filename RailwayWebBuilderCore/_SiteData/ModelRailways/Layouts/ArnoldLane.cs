using RailwayWebBuilderCore.Data;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class ArnoldLane : LayoutBase, ILayoutByLayout
    {
        public ArnoldLane()
        {
            Name = LayoutNamesEnums.ArnoldLane;
            Owner = "Pauline Mckenna";
            Description = ""; // TODO Needs description
            LayoutByLayoutVideo = "https://youtu.be/2KdK28yvDqs";
        }

        
    }
}