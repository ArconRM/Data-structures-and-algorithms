using _3LArchitecture.Common.DTO;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Service.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3LArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    public class ToyController : BaseProductsController<Toy, ToyDTO>
    {
        public ToyController(IProductService<Toy> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
