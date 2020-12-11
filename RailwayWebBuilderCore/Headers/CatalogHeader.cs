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
            Description = "Catalog";
        }
    }
}