using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class ShopGCRAuctionsHeader : HeaderBase, IPageHeader
    {
        public ShopGCRAuctionsHeader()
        {
            Title = "GCR Auctions Reunification";
            Keywords = new List<string>
            {
                "Auctions",
                "Train Painting",
            };
            Description = "GCR Reunification Auctions";

            ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.GALLERY);
        }
    }
}