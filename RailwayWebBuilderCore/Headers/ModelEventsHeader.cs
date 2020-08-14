using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Headers
{
    public class ModelEventsHeader : HeaderBase, IPageHeader
    {
        public ModelEventsHeader()
        {
            Title = "ModelEvents";
            Keywords = new List<string>
            {
                "Model Trains",
                "Model railway"
            };
            MetaDetails = "Modle railway";
        }

        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
