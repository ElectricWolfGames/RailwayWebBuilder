using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Builders.Shop;

namespace RailwayWebBuilderCore.Builders.Shop.Products
{
    public class Product_Cattington_ClassicTee : IProduct
    {
        public string Descrption { get; set; } = "Tee with a nice Cattington Railway logo in the top right, Options for Man and woman.";
        public string Image { get; set; } = "Cattington-Railway-sign-Tee-Mans.jpg";
        public string Title { get; set; } = "Cattington Railway sign Tee's";
        public string URL { get; set; } = "https://teespring.com/cattington-railway-sign-t-s?tsmac=store&tsmic=karl-and-debbie-trains&pid=389&cid=100019";
    }
}
