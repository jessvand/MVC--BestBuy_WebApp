using BestBuy_WebApp.Models;
using Dapper;
using System.Data;

namespace BestBuy_WebApp.Data
{
    public class ProductRepo : IProductRepository
    {
        private readonly IDbConnection _connection;

        public ProductRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM products;");
        }
    }
    
   
}
