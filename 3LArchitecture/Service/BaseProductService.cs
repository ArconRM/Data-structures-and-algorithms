using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;
using _3LArchitecture.Repository.Interfaces;
using _3LArchitecture.Service.Interfaces;

namespace _3LArchitecture.Service;

public class BaseProductService<T>: IProductService<T> where T: Product
{
    private readonly IProductRepository<T> _repository;

    public BaseProductService(IProductRepository<T> repository)
    {
        _repository = repository;
    }

    public List<T> GetAllProducts()
    {
        return _repository.GetAllProducts();
    }

    public List<T> GetProductsByName(string name)
    {
        return _repository.GetProductsByName(name);
    }

    public T AddProduct(T product)
    {
        return _repository.AddProduct(product);
    }

    public void DeleteProduct(Guid uuid)
    {
        _repository.DeleteProduct(uuid);
    }
}