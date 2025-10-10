using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers;

public class ShopGCRHeader : HeaderBase, IPageHeader
{
    public ShopGCRHeader()
    {
        Title = "Reunification Shop";
        Keywords = new List<string>
        {
            "Reunification",
        };
        Description = "GCR Reunification Shop";
    }
}