using BestBuy_WebApp.Data;
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
    }
}
