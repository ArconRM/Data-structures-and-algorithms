using System.Runtime.Serialization.Formatters.Binary;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;
using _3LArchitecture.Repository.Interfaces;
using Newtonsoft.Json;

namespace _3LArchitecture.Repository;

public class BaseProductRepository<T> : IProductRepository<T> where T: Product
{
    //private const string _toys_path =
    //    "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/3LArchitecture/Repository/Assets/toys.json";

    //private const string _sports_equipments_path =
    //    "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/3LArchitecture/Repository/Assets/sports_equipments.json";

    //private const string _books_path =
    //    "/Users/artemiymirotvortsev/Projects/Структуры данных и алгоритмы/3LArchitecture/Repository/Assets/books.json";

    private const string _toys_path =
        "C:/Users/Artemiy/Source/Repos/ArconRM/Data-structures-and-algorithms/3LArchitecture/Repository/Assets/toys.json";

    private const string _sports_equipments_path =
        "C:/Users/Artemiy/Source/Repos/ArconRM/Data-structures-and-algorithms/3LArchitecture/Repository/Assets/sports_equipments.json";

    private const string _books_path =
        "C:/Users/Artemiy/Source/Repos/ArconRM/Data-structures-and-algorithms/3LArchitecture/Repository/Assets/books.json";

    private string _path;


    private readonly JsonSerializerSettings _jsonSettings = new()
    {
        TypeNameHandling = TypeNameHandling.All,
        Formatting = Formatting.Indented
    };

    public BaseProductRepository()
    {
        Type type = typeof(T);

        if (type == typeof(Toy))
        {
            _path = _toys_path;
        }
        else if (type == typeof(SportsEquipment))
        {
            _path = _sports_equipments_path;
        }
        else if (type == typeof(Book))
        {
            _path = _books_path;
        }
        else
        {
            throw new NotSupportedException($"Type {type.Name} is not supported.");
        }
    }

    public List<T> GetAllProducts()
    {
        if (!File.Exists(_path))
            return new List<T>();

        string json = File.ReadAllText(_path);
        return JsonConvert.DeserializeObject<List<T>>(json, _jsonSettings) ?? new List<T>();
    }

    public List<T> GetProductsByName(string name)
    {
        return GetAllProducts()
            .Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public T AddProduct(T product)
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

    private void SaveAllProducts(List<T> products)
    {
        string json = JsonConvert.SerializeObject(products, _jsonSettings);
        File.WriteAllText(_path, json);
    }
}