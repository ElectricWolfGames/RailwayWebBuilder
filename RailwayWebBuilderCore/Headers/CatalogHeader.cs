using eWolfBootstrap.Enums;
using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class CatalogHeader : HeaderBase, IPageHeader
    {
        public CatalogHeader()
        {
            Title = "Catalog";
            Keywords = new List<string>
            {
            };
            MetaDetails = "Catalog";
        }

        public List<BootstrapOptions> ExtraIncludes { get; set; } = new List<BootstrapOptions>();
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
