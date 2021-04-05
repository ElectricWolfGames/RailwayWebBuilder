using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore.Builders.Shop
{
    public class Product_All_Scales : IProduct
    {
        public string Descrption { get; set; } = "<strong>MUG:</strong> All scales cost the same amount - all you can afford them!!!!";
        public string Image { get; set; } = "All-scales-cost-the-same-amount.jpg";
        public string Title { get; set; } = "All scales cost the same amount, MUG";
        public string URL { get; set; } = "https://teespring.com/all-scales-cost-the-same-amoun?tsmac=store&tsmic=karl-and-debbie-trains&pid=659&cid=102910";
    }
}