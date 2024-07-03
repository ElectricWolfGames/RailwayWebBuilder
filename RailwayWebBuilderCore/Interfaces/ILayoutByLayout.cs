using eWolfBootstrap.Helpers;
using RailwayWebBuilderCore.Enums;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILayoutByLayout
    {
        string Description { get; set; }
        List<ImagesPair> Images { get; set; }
        string LayoutByLayoutVideo { get; set; }
        LayoutNamesEnums Name { get; set; }
        string Owner { get; set; }
    }
}