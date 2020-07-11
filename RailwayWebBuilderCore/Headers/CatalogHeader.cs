using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Headers
{
    public class CatalogHeader : HeaderBase, IPageHeader
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }

        public CatalogHeader()
        {
            Title = "Catalog";
            Keywords = new List<string>
            {
            };
            MetaDetails = "Catalog";
        }
    }
}
