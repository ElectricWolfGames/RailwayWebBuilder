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
                "GCR",
                "GCRN",
                "Rushcliffe Halt",
                "Loughborough",
            };
            Description = "Railway Stations";
        }
    }
}
