using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Builders.Shop;

namespace RailwayWebBuilderCore.Builders.Shop.Products
{
    public class Product_Cattington_Facemask : IProduct
    {
        public string Descrption { get; set; } = "<strong>Facemask:</strong> with a nice Cattington Railway logo";
        public string Image { get; set; } = "Cattington-Face-mask.jpg";
        public string Title { get; set; } = "Cattington Face mask";
        public string URL { get; set; } = "https://teespring.com/cattington?tsmac=store&tsmic=karl-and-debbie-trains&pid=1026&cid=104065";
    }
}
