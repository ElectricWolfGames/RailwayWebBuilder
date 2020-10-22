using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class ModelEventsHeader : HeaderBase, IPageHeader
    {
        public ModelEventsHeader()
        {
            Title = "ModelEvents";
            Keywords = new List<string>
            {
                "Model Trains",
                "Model railway",
                "N Gauge Model Railways",
                "OO Gauge Model Railways",
                "Hornby",
                "Model staions",
            };
            Description = "Model railway events pages";
        }
    }
}
