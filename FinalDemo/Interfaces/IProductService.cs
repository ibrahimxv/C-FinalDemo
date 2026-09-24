using ConsoleApp4.Models;

namespace ConsoleApp4.Interfaces;

public interface IProductService
{
    void AddProduct(Product product);
    void RemoveProduct(int id);
    void RestoreProduct(int id);
    void GetProduct(Product product);
    List<Product> GetAllProducts();
    List<Product> SearchProducts(string keyword);

}