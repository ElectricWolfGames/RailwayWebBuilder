using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public class ModelEventsHeader : IHeader
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
