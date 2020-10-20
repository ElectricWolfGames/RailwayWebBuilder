using eWolfBootstrap.Enums;
using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class StationsHeader : HeaderBase, IPageHeader
    {
        public StationsHeader()
        {
            Title = "Stations";
            Keywords = new List<string>
            {
                "Stations",
            };
            MetaDetails = "Railway Stations";
        }

        public List<BootstrapOptions> ExtraIncludes { get; set; } = new List<BootstrapOptions>();
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
