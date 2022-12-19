using Microsoft.AspNetCore.Mvc;

namespace MVC_fixxo.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
