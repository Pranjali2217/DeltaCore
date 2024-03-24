// ProductsController.cs
using Microsoft.AspNetCore.Mvc;
using DeltaCore.Models;

namespace DeltaCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }

        public IActionResult Index()
        {
            var products = _productsService.GetProducts();
            return View(products);
        }
    }
}
