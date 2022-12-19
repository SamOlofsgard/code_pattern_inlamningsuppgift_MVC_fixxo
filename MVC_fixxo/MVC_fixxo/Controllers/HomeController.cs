using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_fixxo.Context;
using MVC_fixxo.Handlers;
using MVC_fixxo.Models;
using System.Diagnostics;


/// Single responsibility principle (SRP) är att en klass eller kontroll har ett ansvarsområde, här ska den bara hämta en lista med produkter
/// Dependency inversion principle (DIP) är att klasser inte ska vara beroende utav varandra utan av andra gränssnitt som hålls här på annan nivå
/// En interface som sköter produktlistan enskilt.
/// ISP principen används också här genom många gränssnitt som på gränsen kanske inte behövs just här men om det ska utvecklas med flera kategorier och 
/// mer info om varje produkt, med egna listor på vad som är populärt m.m.. så blir det smidigare med fler gränssnitt som särskiljer alla delarna.



namespace MVC_fixxo.Controllers
{

    public class HomeController : Controller
    {
        private readonly IProductHandler _productHandler;

        public HomeController(IProductHandler productHandler)
        {
            _productHandler = productHandler;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productHandler.GetAllAsync();
            return View(products);
        }

    }
}