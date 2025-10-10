using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers;

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
            "home layout",
            "model layout",
            "train layout",
            "N Gauge Model Railways",
            "OO Gauge Model Railways",
            "Hornby",
            "bachmann",
            "Model staions",
            "Railways",
            "trains at home",
            "trains",
            "Cattington Town",
            "Cattington Railway",
            "Cattington",
            "Cattington History",
            "Cattington Videos",
            "Cattington Making of",
        };

        Description = "Modle railways";
    }
}