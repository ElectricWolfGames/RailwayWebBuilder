using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class ShopHeader : HeaderBase, IPageHeader
    {
        public ShopHeader()
        {
            Title = "Karl and Debbie Trains Shop";
            Keywords = new List<string>
            {
                "Train Shop",
                "Cattington Shop",
                "Railway Shop",
                "Karl and Debbie Trains  Shop",
                "Train Merchandise",
            };
            Description = "Shop";
        }
    }
}