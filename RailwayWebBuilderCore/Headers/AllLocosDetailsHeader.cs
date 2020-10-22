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
            Description = "Locomotive detailsa";
        }
    }
}
