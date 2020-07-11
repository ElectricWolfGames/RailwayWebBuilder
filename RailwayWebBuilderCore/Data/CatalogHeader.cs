using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public class CatalogHeader : IHeader
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
