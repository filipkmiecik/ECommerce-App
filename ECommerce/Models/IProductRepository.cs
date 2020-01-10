using System.Collections.Generic;

//Test v2
namespace ECommerce.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
    }
}
