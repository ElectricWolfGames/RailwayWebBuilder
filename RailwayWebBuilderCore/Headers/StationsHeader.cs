using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Headers
{
    public class HeaderBase
    {
        public string Author { get; set; } = "Electric Wolf";
    }

    public class StationsHeader : HeaderBase, IPageHeader
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }

        public StationsHeader()
        {
            Title = "Stations";
            Keywords = new List<string>
            {
                "Stations",
            };
            MetaDetails = "Railway Stations";
        }
    }
}
