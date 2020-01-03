using ECommerce.Models;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
                Title = "E-CommerceShop",
                Products = products.ToList()
            };
            return View(homeVM);
        }
    }
}
