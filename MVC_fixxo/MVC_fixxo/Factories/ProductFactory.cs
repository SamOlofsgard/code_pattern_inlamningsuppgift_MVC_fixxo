using MVC_fixxo.Interfaces;
using MVC_fixxo.Models.Entities;
using MVC_fixxo.Models;

namespace MVC_fixxo.Factories
{
    public interface IProductFactory : IFactory
    {
        ProductEntity ProductEntity();
        Product Product(ProductEntity productEntity);
        List<Product> ProductList();

    }
    public class ProductFactory : IProductFactory
    {
        public ProductEntity ProductEntity()
        {
            return new ProductEntity();
        }

        public Product Product(ProductEntity productEntity)
        {
            return new Product()
            {
                ArticleNumber = productEntity.ArticleNumber,
                Name = productEntity.Name,
                Rated = productEntity.Rated,
                NewPrice = productEntity.NewPrice,
                OldPrice = productEntity.OldPrice,
                CategoryId = productEntity.CategoryId,
                Description = productEntity.Description,
                Size = productEntity.Size,
                Color = productEntity.Color,
                Image1 = productEntity.Image1,
                Image2 = productEntity.Image2,
                Image3 = productEntity.Image3
            };
        }

        public List<Product> ProductList()
        {
            return new List<Product>();
        }
    }


}
