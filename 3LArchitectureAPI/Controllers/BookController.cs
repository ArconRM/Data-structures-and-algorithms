using _3LArchitecture.Common.DTO;
using _3LArchitecture.Common.Entities;
using _3LArchitecture.Service.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _3LArchitectureAPI.Controllers
{
    [Route("api/[controller]")]
    public class BookController : BaseProductsController<Book, BookDTO>
    {
        public BookController(IProductService<Book> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
