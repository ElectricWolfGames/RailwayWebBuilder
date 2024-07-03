using eWolfBootstrap.Helpers;
using RailwayWebBuilderCore.Enums;
using System.Collections.Generic;

namespace RailwayWebBuilderCore._SiteData.ModelRailways
{
    internal class LayoutBase : ILayoutBase
    {
        public string Description { get; set; }
        public List<ImagesPair> Images { get; set; } = new List<ImagesPair>();
        public string LayoutByLayoutVideo { get; set; }
        public LayoutNamesEnums Name { get; set; }
        public string Owner { get; set; }
    }
}