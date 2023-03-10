using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;




///SRP och OCP principer productEntity har ett ansvarsområde och är låsta på det området, får utöka med andra klasser och funktioner vid behov. 
namespace MVC_fixxo.Models.Entities
{
    public class ProductEntity
    {
        [Key]
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
