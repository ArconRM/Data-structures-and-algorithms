using _3LArchitecture.Common.DTO;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;
using _3LArchitecture.Service.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3LArchitectureAPI.Controllers;

[Route("api/[controller]")]
public class ProductsController: Controller
{
    private readonly IProductService _service;
    
    private readonly IMapper _mapper;

    public ProductsController(IProductService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(nameof(GetAllProducts))]
    public IActionResult GetAllProducts()
    {
        try
        {
            List<Product> products = _service.GetAllProducts();
            return Ok(products.Select(p => p.ToString()).ToList());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpGet(nameof(GetSortedByAge))]
    public IActionResult GetSortedByAge()
    {
        try
        {
            List<Product> products = _service.GetAllProducts();
            products.Sort();
            return Ok(products.Select(p => p.ToString()).ToList());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost(nameof(FindProductsByType))]
    public IActionResult FindProductsByType([FromBody] ProductType productType)
    {
        try
        {
            List<string> products = _service.FindProductsByType(productType).Select(p => p.ToString()).ToList();
            return Ok(products);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost(nameof(AddToy))]
    public IActionResult AddToy([FromBody] ToyDTO toyDTO)
    {
        try
        {
            Toy toy = _mapper.Map<ToyDTO, Toy>(toyDTO);
            _service.AddProduct(toy);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost(nameof(AddSportsEquipment))]
    public IActionResult AddSportsEquipment([FromBody] SportsEquipmentDTO sportsEquipmentDTO)
    {
        try
        {
            SportsEquipment toy = _mapper.Map<SportsEquipmentDTO, SportsEquipment>(sportsEquipmentDTO);
            _service.AddProduct(toy);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost(nameof(AddBook))]
    public IActionResult AddBook([FromBody] BookDTO bookDTO)
    {
        try
        {
            Book book = _mapper.Map<BookDTO, Book>(bookDTO);
            _service.AddProduct(book);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpDelete(nameof(DeleteProduct))]
    public IActionResult DeleteProduct([FromBody] Guid uuid)
    {
        try
        {
            _service.DeleteProduct(uuid);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost(nameof(RestoreFromBackup))]
    public IActionResult RestoreFromBackup()
    {
        try
        {
            _service.RestoreFromBackup();
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}