using BestBuy_WebApp.Models;


namespace BestBuy_WebApp.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}

