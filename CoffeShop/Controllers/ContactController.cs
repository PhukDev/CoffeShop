using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class ContactController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
