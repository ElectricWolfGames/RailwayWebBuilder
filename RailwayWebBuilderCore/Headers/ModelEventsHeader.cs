using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Headers
{
    public class ModelEventsHeader : HeaderBase, IPageHeader
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }

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
    }
}
