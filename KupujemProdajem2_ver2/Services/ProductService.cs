using KupujemProdajem2_ver2.Interface;
using KupujemProdajem2_ver2.Models;

namespace KupujemProdajem2_ver2.Services;
public class ProductService : IProductService
{
    public IEnumerable<Product> GetProducts()
    {
        var products = new List<Product>();

        products.Add(new Product
        {
            Id = 1,
            Name = "Daska 2x2",
            Price = 100,
        });
        products.Add(new Product
        {
            Id = 2,
            Name = "Slusalice Sony XM4",
            Price = 200,
        });
        products.Add(new Product
        {
            Id = 3,
            Name = "LG 4k OLED",
            Price = 300,
        });

        return products;
    }
}
