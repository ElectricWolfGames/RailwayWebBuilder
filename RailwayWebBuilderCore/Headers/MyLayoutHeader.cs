using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Headers
{
    public class MyLayoutHeader : HeaderBase, IPageHeader
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }

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
    }
}
