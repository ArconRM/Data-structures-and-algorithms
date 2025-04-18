using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;
using _3LArchitecture.Repository.Interfaces;
using _3LArchitecture.Service.Interfaces;

namespace _3LArchitecture.Service;

public class ProductService: IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public List<Product> GetAllProducts()
    {
        return _repository.GetAllProducts();
    }

    public List<Product> GetProductsByName(string name)
    {
        return _repository.GetProductsByName(name);
    }

    public List<Product> FindProductsByType(ProductType productType)
    {
        return _repository.FindProductsByType(productType);
    }

    public Product AddProduct(Product product)
    {
        return _repository.AddProduct(product);
    }

    public void DeleteProduct(Guid uuid)
    {
        _repository.DeleteProduct(uuid);
    }

    public List<Product> RestoreFromBackup()
    {
        return _repository.RestoreFromBackup();
    }
}