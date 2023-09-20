using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class MyLayoutHeader : HeaderBase, IPageHeader
    {
        public MyLayoutHeader()
        {
            Title = "Our Layouts";
            Keywords = new List<string>
            {
                "Model Trains",
                "Model railway",
                "Home layout",
                "Cattington Town",
                "Cattington Railway",
                "Cattington",
                "Cattington History",
                "Cattington Videos",
                "Cattington Making of",
                "hornby",
                "Fix layout",
                "UK home layout",
                "Model train display",
                "railway model",
            };
            Description = "Cattington model railway";
        }
    }
}