using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Context;

namespace MVC_fixxo.Controllers
{
    public class ProductItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var productEntity = await _context.Products
                .FirstOrDefaultAsync(m => m.ArticleNumber == id);
            if (productEntity == null)
            {
                return NotFound();
            }
            return View(productEntity);
        }
    }
}
