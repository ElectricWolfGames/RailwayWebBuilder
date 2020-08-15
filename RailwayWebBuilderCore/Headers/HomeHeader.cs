using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class HomeHeader : HeaderBase, IPageHeader
    {
        public HomeHeader()
        {
            Title = "Home";
            Keywords = new List<string>();
            Keywords.Add("Model Trains");
            Keywords.Add("Model railway");
            MetaDetails = "Modle railway";
        }

        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }
        public string Title { get; set; }
    }
}
