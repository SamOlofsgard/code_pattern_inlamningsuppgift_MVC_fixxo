namespace MVC_fixxo.Models
{
    public class Product
    {
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Rated { get; set; } = null!;
        public decimal NewPrice { get; set; }
        public decimal OldPrice { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Image1 { get; set; } = null!;
        public string Image2 { get; set; } = null!;
        public string Image3 { get; set; } = null!;
    }
}
