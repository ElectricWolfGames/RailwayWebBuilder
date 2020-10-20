using eWolfBootstrap.Enums;
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
                "Model railway"
            };
            MetaDetails = "Modle railway";
        }

        public List<BootstrapOptions> ExtraIncludes { get; set; } = new List<BootstrapOptions>();
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
