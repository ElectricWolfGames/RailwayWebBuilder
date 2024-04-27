using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILayoutByLayout
    {
        public string LayoutByLayoutVideo { get; set; }

        public string Description { get; set; }
        
        public LayoutNamesEnums Name { get; set; }
        public string Owner { get; set; }
    }
}