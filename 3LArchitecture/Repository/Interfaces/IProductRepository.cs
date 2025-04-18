using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;

namespace _3LArchitecture.Repository.Interfaces;

public interface IProductRepository
{
    public List<Product> GetAllProducts();
    
    public List<Product> GetProductsByName(string name);

    public List<Product> FindProductsByType(ProductType productType);

    public Product AddProduct(Product product);

    public void DeleteProduct(Guid uuid);

    public List<Product> RestoreFromBackup();
}