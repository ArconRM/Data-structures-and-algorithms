using _3LArchitecture.Common.DTO;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Service.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3LArchitectureAPI.Controllers
{

    [Route("api/[controller]")]
    public class SportsEquipmentController : BaseProductsController<SportsEquipment, SportsEquipmentDTO>
    {
        public SportsEquipmentController(IProductService<SportsEquipment> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
