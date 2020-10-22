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
                "N Gauge Model Railways",
                "OO Gauge Model Railways",
                "Hornby",
                "Model staions",
                "Railways",
                "trains at home",
                "trains",
            };

            Description = "Modle railway";
        }
    }
}
