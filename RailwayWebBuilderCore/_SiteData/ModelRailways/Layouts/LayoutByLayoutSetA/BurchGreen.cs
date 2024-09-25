using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class BurchGreen : LayoutBase, ILayoutByLayoutSetA
    {
        public BurchGreen()
        {
            Name = LayoutNamesEnums.BurchGreen;
            Owner = "Les Richardson";
            Description = "A new OO gauge layout from Bingham Model Railway ClubThis layout was inspired by the exhibition layouts of the late Chris Burch, and is designed to be operated by adults and children alike.Freelance in nature the layout takes the form of a classic shunting puzzle. Operated from the front. The public, especially children, are invited to try shunting, while one of the layout operators has anoverride in case of problems.Size 8 feet by 2 feet.";
            LayoutByLayoutVideo = "https://youtu.be/F_Z_CwUWa3U";
        }
    }
}