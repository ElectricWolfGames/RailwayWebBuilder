using eWolfBootstrap.Helpers;
using RailwayWebBuilderCore.Enums;
using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData.ModelRailways
{
    internal interface ILayoutBase
    {
        string Description { get; set; }
        List<ImagesPair> Images { get; set; }
        LayoutNamesEnums Name { get; set; }
        string Owner { get; set; }
    }
}