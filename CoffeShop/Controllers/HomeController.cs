using System.Diagnostics;
using CoffeShop.Models;
using CoffeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeShop.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var trendingProducts = productRepository.GetTrendingProducts(); // Thực thi phương thức
            return View(trendingProducts); 
        }

        
    }
}
