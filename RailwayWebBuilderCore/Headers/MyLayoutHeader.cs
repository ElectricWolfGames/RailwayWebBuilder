using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class MyLayoutHeader : HeaderBase, IPageHeader
    {
        public MyLayoutHeader()
        {
            Title = "My Layouts";
            Keywords = new List<string>
            {
                "Model Trains",
                "Model railway",
                "Home layout"
            };
            MetaDetails = "Home model railway";
        }

        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
