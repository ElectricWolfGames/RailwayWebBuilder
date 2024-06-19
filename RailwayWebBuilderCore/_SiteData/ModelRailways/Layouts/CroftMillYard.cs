﻿using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class CroftMillYard : LayoutBase, ILayoutByLayout
    {
        public CroftMillYard()
        {
            Name = LayoutNamesEnums.CroftMillWharf;
            Owner = "Ian Atkinson";
            Description = ""; // TODO CroftMillWharf Needs description
            LayoutByLayoutVideo = "";
        }
    }
}