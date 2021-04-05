using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class HomeHeader : HeaderBase, IPageHeader
    {
        public HomeHeader()
        {
            Title = "Home";
            Keywords = new List<string>
            {
                "Model Trains",
                "Model railway",
                "Home railway",
                "N Gauge Model Railways",
                "OO Gauge Model Railways",
                "Hornby",
                "Model staions",
                "Railways",
                "trains at home",
                "trains",
                "Cattington",
                "Cattington Railway",
            };

            Description = "Modle railways";
        }
    }
}