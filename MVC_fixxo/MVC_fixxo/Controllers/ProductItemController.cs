using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Context;


///Interface segregation principle (ISP) där gränssnitten är många och enkla. ProductItemController är bara för användaren, ska en adminstratör lägga till, ändra eller ta bort
///produkter så skapar man en annan kontroller som kan nås av adminstratören. 
/// Open/closed principle (OCP) det går att utöka kontrollen eller lägga till en extra kontroller för att hantera andra funktioner som t.ex. Edit, Delete en produkt

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
