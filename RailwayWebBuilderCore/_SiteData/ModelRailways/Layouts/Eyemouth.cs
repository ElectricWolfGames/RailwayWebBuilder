using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class Eyemouth : LayoutBase, ILayoutByLayout
    {
        public Eyemouth()
        {
            Name = LayoutNamesEnums.Eyemouth;

            Owner = "";
            Description = "This working model depicts the station area as it was in the years after WWII. The project was begun during the lockdown period in March 2020 and took almost a year to complete, each element taking many hours to create, inspiration stemming from an article in Steam Days magazine (Feb. '99). I had read this some years before and had thought that it would make an interesting project at some point. The confinement that came about in spring 2020 was the ideal opportunity to begin to turn it into a reality. The railway facilities provided at the station being fairly simple, just an entry road with run-round loop and two sidings, it was the handsome row of houses along Victoria Road that was the main attraction for me. In addition, the land levels from the river to the houses provide another interesting dimension. The buildings were all \"scratch built\", that is individually crafted from plain plastic sheet, laminated with stone, brick or tile sheets in the same material. Dimensions were gained by using a measurement tool on a mapping website. Traffic was limited to a return passenger service from Burnmouth, on the main line north of Berwick-upon-Tweed, freight being largely concerned with the fishing industry. The line closed in 1962 and there is little trace of it left.";
        }
    }
}