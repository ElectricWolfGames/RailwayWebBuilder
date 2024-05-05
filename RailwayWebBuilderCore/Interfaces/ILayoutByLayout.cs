using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILayoutByLayout
    {
        public string Description { get; set; }
        public string LayoutByLayoutVideo { get; set; }
        public LayoutNamesEnums Name { get; set; }
        public string Owner { get; set; }
    }
}