using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts;

internal class Torcy : LayoutBase, ILayoutByLayoutSetA
{
    public Torcy()
    {
        Name = LayoutNamesEnums.Torcy;
        Owner = "Peter and John Smith";
        Description = "TORCY (SNCF) Torcy is located in the Department of Seine-Maritime in theHaute Normandie, (Upper Normandy), Region of NorthernFrance at the end of a single track branch off the line fromRouen to Dieppe. Torcy is a real place but the railway iscompletely fictitiousThe survival of the imaginary branch line is due, in the main,to a distribution depot set up to transfer goods arriving by railto road vehicles for delivery to this area of northern France,the level of freight traffic is sufficiently healthy to requireseveral trains a day. In addition, loaded trains of openwagons containing gravel from a quarry up the line, that onlyhas access from the Torcy direction, enter the station area toreverse before departing to Sotteville yard in Rouen foronward dispatch.The station also survives and is served by a regularpassenger service from Rouen operated by diesel-poweredpush-pull trains and multiple units. ";
        LayoutByLayoutVideo = "";
    }
}