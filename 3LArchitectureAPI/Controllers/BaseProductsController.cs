using _3LArchitecture.Common.DTO;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Common.Entities.Enums;
using _3LArchitecture.Service.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3LArchitectureAPI.Controllers;

public class BaseProductsController<T, Dto>: Controller where T: Product
{
    private readonly IProductService<T> _service;
    
    private readonly IMapper _mapper;

    public BaseProductsController(IProductService<T> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet(nameof(GetAll))]
    public IActionResult GetAll()
    {
        try
        {
            List<T> products = _service.GetAllProducts();
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
            List<T> products = _service.GetAllProducts();
            products.Sort();
            return Ok(products.Select(p => p.ToString()).ToList());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpPost(nameof(Add))]
    public IActionResult Add([FromBody] Dto productDTO)
    {
        try
        {
            T product = _mapper.Map<Dto, T>(productDTO);
            _service.AddProduct(product);
            return Ok();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpDelete(nameof(Delete))]
    public IActionResult Delete([FromBody] Guid uuid)
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
}