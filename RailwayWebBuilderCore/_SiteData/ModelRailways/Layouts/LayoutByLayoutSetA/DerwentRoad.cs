using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class DerwentRoad : LayoutBase, ILayoutByLayoutSetA
    {
        public DerwentRoad()
        {
            Name = LayoutNamesEnums.DerwentRoad;

            Owner = "";
            Description = "The layout was inspired by visits to the Leighton Buzzard Light Railway. This model is of a fictitious 18' gauge line built to the west of the standard gauge main line that would have been the destination for loaded sand trains. The railway is shared between the sand company and the preservation society with sand trains still running the entire length of the railway but the preser-vation society's passenger trains terminate at Derwent Road. The base-boards are built from 6mm ply. Derwent Road is controlled using a Digitrax DCC system: track is Peco 009 with Cobalt IP digital point motors. The con-trol system, lights and sound are built into the two boards: this reduces the layout setup time. The photographic backdrop was produced by a com-mercial printing firm from a panorama of 6 images. The rolling stock is a mixture of kits and scratch built";
            LayoutByLayoutVideo = "";
        }
    }
}