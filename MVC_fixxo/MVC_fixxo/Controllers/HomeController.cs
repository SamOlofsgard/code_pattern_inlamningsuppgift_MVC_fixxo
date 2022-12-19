using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Context;
using MVC_fixxo.Models;
using System.Diagnostics;

namespace MVC_fixxo.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        
        public HomeController(ApplicationDbContext context)
        {
            
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return _context.Products != null ?
                         View(await _context.Products.ToListAsync()) :
                         Problem("Entity set 'ApplicationDbContext.Products'  is null.");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}