using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;

namespace _3LArchitecture.Repository.Interfaces;

public interface IProductRepository<T> where T: Product
{
    public List<T> GetAllProducts();
    
    public List<T> GetProductsByName(string name);

    public T AddProduct(T product);

    public void DeleteProduct(Guid uuid);
}