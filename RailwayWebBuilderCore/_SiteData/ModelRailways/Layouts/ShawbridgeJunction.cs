﻿using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class ShawbridgeJunction : LayoutBase, ILayoutByLayout
    {
        public ShawbridgeJunction()
        {
            Name = LayoutNamesEnums.ShawbridgeJunction;
            Owner = "The Elizabethan Society";
            Description = ""; // TODO Needs description
            LayoutByLayoutVideo = "";
        }
    }
}