using System.Collections.Generic;
using System.Linq;
using Store.Models;

namespace WebApplication.Repositories
{
    public interface IProductsRepository
    {
        IEnumerable<Products> GetAllProducts();
    }
    public class ProductsRepository : IProductsRepository
    {
        private StoreContext db = new StoreContext();
        public IEnumerable<Products> GetAllProducts()
        {
            List<string> products = new List<string>();
            var product = db.Products.ToList();
            return product;

        }
    }
}
