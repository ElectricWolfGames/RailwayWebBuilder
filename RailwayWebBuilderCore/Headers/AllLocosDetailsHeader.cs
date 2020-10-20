using eWolfBootstrap.Enums;
using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class AllLocosDetailsHeader : HeaderBase, IPageHeader
    {
        public AllLocosDetailsHeader()
        {
            Title = "AllLocosDetailsHeader ";
            Keywords = new List<string>
            {
                "All Locos",
                "train tables",
                "train list",
                "Locomotive list",
                "Locomotive details",
                "Locomotive by total built",
            };
            MetaDetails = "Locomotive detailsa";
        }

        public List<BootstrapOptions> ExtraIncludes { get; set; } = new List<BootstrapOptions>() { BootstrapOptions.BT };
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
