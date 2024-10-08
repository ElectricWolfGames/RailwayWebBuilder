﻿using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts.LayoutByLayoutSetA
{
    internal class BlueHeron : LayoutBase, ILayoutByLayoutSetA
    {
        public BlueHeron()
        {
            Name = LayoutNamesEnums.BlueHeron;
            Owner = "Andy Gautrey";
            Description = "Blue Heron depicts a small urban switching yard on a rainy night in the Pacific North-west area of the USA. Visitors are welcome to try the inglenook challenge and switch the cars into the randomly generated order";
            LayoutByLayoutVideo = "";
        }
    }
}