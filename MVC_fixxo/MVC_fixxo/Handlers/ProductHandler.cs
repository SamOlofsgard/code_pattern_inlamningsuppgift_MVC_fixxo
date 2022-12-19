using MVC_fixxo.Models.Entities;
using MVC_fixxo.Models;
using MVC_fixxo.Context;
using MVC_fixxo.Factories;
using Microsoft.EntityFrameworkCore;

namespace MVC_fixxo.Handlers
{
    public interface IProductHandler
    {
        Task CreateAsync(ProductRequest req);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<ProductEntity> GetAsync(int id);
    }

    public class ProductHandler : IProductHandler
    {
        private readonly ApplicationDbContext _sql;
        private readonly IProductFactory _factory;

        public ProductHandler(ApplicationDbContext sql, IProductFactory factory)
        {            
            _sql = sql;
            _factory = factory;
        }

        public async Task CreateAsync(ProductRequest req)
        {
            var productEntity = _factory.ProductEntity();


            productEntity.ArticleNumber = req.ArticleNumber;
            productEntity.Name = req.Name;
            productEntity.Rated = req.Rated;
            productEntity.NewPrice = req.NewPrice;
            productEntity.OldPrice = req.OldPrice;
            productEntity.CategoryId = req.CategoryId;
            productEntity.Description = req.Description;
            productEntity.Size = req.Size;
            productEntity.Color = req.Color;
            productEntity.Image1 = req.Image1;
            productEntity.Image2 = req.Image2;
            productEntity.Image3 = req.Image3;


            _sql.Add(productEntity);
            await _sql.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            List<Product> products = _factory.ProductList();

            foreach (var productEntity in await _sql.Products.ToListAsync())
                products.Add(_factory.Product(productEntity));

            return products;
        }

        public Task<ProductEntity> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
