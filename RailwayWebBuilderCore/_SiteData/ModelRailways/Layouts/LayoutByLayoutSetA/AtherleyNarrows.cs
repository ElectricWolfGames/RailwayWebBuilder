using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts.LayoutByLayoutSetA;

internal class AtherleyNarrows : LayoutBase, ILayoutByLayoutSetA
{
    public AtherleyNarrows()
    {
        Name = LayoutNamesEnums.AtherleyNarrows;
        Owner = "C. Round";
        Description = "Since visiting Toronto in Canada in 1990 and 1994, I have built two layouts based on the trains I saw then and in particular those of the Canadian Pacific railway or CP Rail as it was then. It is inspired by a photograph I had taken of a swing bridge at Atherley near Orillia in Ontario. My initial thought was to build a simple diorama of the bridge and its approach piers, but it soon expanded and I can now run 20ft long trains. The track plan for Atherley Narrows allows for industries to be served from loops off the main line and these can be operated at the same time as trains pass on the main.";
        LayoutByLayoutVideo = "https://youtu.be/5ksULqHYkms";
    }
}