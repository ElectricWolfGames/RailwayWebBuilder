using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Torcy : LayoutBase, ILayoutByLayout
    {
        public Torcy()
        {
            Name = LayoutNamesEnums.Torcy;
            Owner = "Peter and John Smith";
            Description = "TORCY (SNCF) Torcy is located in the Department of Seine-Maritime in the\r\nHaute Normandie, (Upper Normandy), Region of Northern\r\nFrance at the end of a single track branch off the line from\r\nRouen to Dieppe. Torcy is a real place but the railway is\r\ncompletely fictitious\r\n\r\nThe survival of the imaginary branch line is due, in the main,\r\nto a distribution depot set up to transfer goods arriving by rail\r\nto road vehicles for delivery to this area of northern France,\r\nthe level of freight traffic is sufficiently healthy to require\r\nseveral trains a day. In addition, loaded trains of open\r\nwagons containing gravel from a quarry up the line, that only\r\nhas access from the Torcy direction, enter the station area to\r\n\r\nreverse before departing to Sotteville yard in Rouen for\r\nonward dispatch.\r\n\r\nThe station also survives and is served by a regular\r\npassenger service from Rouen operated by diesel-powered\r\npush-pull trains and multiple units. ";
            LayoutByLayoutVideo = "";
        }
    }
}