using BestBuy_WebApp.Data;
using BestBuy_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BestBuy_WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;   

        public ProductController (IProductRepository _repo)
        {
            _repository = _repo;
        }
        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = _repository.GetProduct(id);
            return View(product);
        }

        public IActionResult UpdateProduct(int id)
        {
            Product prod = _repository.GetProduct(id);
            if (prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);
        }

        public IActionResult UpdateProductToDatabase(Product product)
        {
            _repository.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }
    }
}
