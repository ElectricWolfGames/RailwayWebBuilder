using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Data
{
    public class HomeHeader : IHeader
    {
        public string Title { get; set; }
        public List<string> Keywords { get; set; }
        public string MetaDetails { get; set; }

        public HomeHeader()
        {
            Title = "Home";
            Keywords = new List<string>();
            Keywords.Add("Model Trains");
            Keywords.Add("Model railway");
            MetaDetails = "Modle railway";
        }
    }
}
