using BestBuy_WebApp.Models;
using Testing.Models;


namespace BestBuy_WebApp.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);

        void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);

        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();

        public void DeleteProduct(Product product);

    }
}

