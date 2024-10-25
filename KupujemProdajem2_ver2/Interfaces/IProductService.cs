using KupujemProdajem2_ver2.Models;

namespace KupujemProdajem2_ver2.Interface;
public interface IProductService
{
    IEnumerable<Product> GetProducts();
}
