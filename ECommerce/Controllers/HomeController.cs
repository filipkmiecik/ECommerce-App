using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;

//Test
namespace ECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
