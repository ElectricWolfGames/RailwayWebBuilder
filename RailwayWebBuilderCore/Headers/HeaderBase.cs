using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public abstract class HeaderBase
    {
        public HeaderBase()
        {
        }

        public string Author { get; set; } = "Electric Wolf";
        public string Description { get; set; }
        public List<string> Keywords { get; set; } = new List<string>();
        public string Title { get; set; }
    }
}