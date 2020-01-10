using ECommerce.Models;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

//Test
//Test v2
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
            var products = _productRepository.GetAllProducts().OrderBy(product => product.Name);

            var homeVM = new HomeVM()
            {
                Title = "Our Products:",
                Products = products.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
