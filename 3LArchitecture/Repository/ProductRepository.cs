using System.Runtime.Serialization.Formatters.Binary;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;
using _3LArchitecture.Repository.Interfaces;
using Newtonsoft.Json;

namespace _3LArchitecture.Repository;

public class ProductRepository : IProductRepository
{
    private const string _path =
        "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/3LArchitecture/Repository/Assets/data.json";

    private const string _backup_path =
        "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/3LArchitecture/Repository/Assets/data_backup.json";

    private readonly JsonSerializerSettings _jsonSettings = new()
    {
        TypeNameHandling = TypeNameHandling.All,
        Formatting = Formatting.Indented
    };

    public List<Product> GetAllProducts()
    {
        if (!File.Exists(_path))
            return new List<Product>();

        string json = File.ReadAllText(_path);
        return JsonConvert.DeserializeObject<List<Product>>(json, _jsonSettings) ?? new List<Product>();
    }

    public List<Product> GetProductsByName(string name)
    {
        return GetAllProducts()
            .Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Product> FindProductsByType(ProductType productType)
    {
        var products = GetAllProducts();
        switch (productType)
        {
            case ProductType.Book:
                return products.Where(p => p.MathesType(typeof(Book))).ToList();
            
            case ProductType.Toy:
                return products.Where(p => p.MathesType(typeof(Toy))).ToList();
            
            case ProductType.SportsEquipment:
                return products.Where(p => p.MathesType(typeof(SportsEquipment))).ToList();
        }

        return new List<Product>();
    }

    public Product AddProduct(Product product)
    {
        var products = GetAllProducts();
        products.Add(product);
        SaveAllProducts(products);
        return product;
    }

    public void DeleteProduct(Guid uuid)
    {
        var products = GetAllProducts();
        products.RemoveAll(p => p.UUID == uuid);
        SaveAllProducts(products);
    }

    public List<Product> RestoreFromBackup()
    {
        string json = File.ReadAllText(_backup_path);
        List<Product> products =
            JsonConvert.DeserializeObject<List<Product>>(json, _jsonSettings) ?? new List<Product>();
        SaveAllProducts(products);
        return products;
    }

    private void SaveAllProducts(List<Product> products)
    {
        string json = JsonConvert.SerializeObject(products, _jsonSettings);
        File.WriteAllText(_path, json);
    }
}