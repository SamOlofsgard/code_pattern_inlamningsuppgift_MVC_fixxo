using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Context;
using MVC_fixxo.Models;
using System.Diagnostics;


/// Single responsibility principle (SRP) är att en klass eller kontroll har ett ansvarsområde, här ska den bara hämta en lista med produkter



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
        
    }
}