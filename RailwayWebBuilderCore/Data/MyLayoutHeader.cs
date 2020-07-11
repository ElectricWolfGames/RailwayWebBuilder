using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public class MyLayoutHeader : IHeader
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
