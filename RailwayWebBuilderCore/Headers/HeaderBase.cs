using eWolfBootstrap.Enums;
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
        public List<BootstrapOptions> ExtraIncludes { get; set; } = new List<BootstrapOptions>();
        public List<string> Keywords { get; set; } = new List<string>();
        public string Title { get; set; }
    }
}
