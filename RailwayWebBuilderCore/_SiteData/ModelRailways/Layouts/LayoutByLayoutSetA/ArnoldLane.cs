using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts.LayoutByLayoutSetA;

internal class ArnoldLane : LayoutBase, ILayoutByLayoutSetA
{
    public ArnoldLane()
    {
        Name = LayoutNamesEnums.ArnoldLane;
        Owner = "Pauline Mckenna";
        Description = "";
        LayoutByLayoutVideo = "https://youtu.be/2KdK28yvDqs";
    }
}