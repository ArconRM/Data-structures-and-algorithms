using _3LArchitecture.Common.Entities;
using _3LArchitecture.Repository.Interfaces;
using _3LArchitecture.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LArchitecture.Service
{
    public class BookService : BaseProductService<Book>
    {
        public BookService(IProductRepository<Book> repository) : base(repository)
        {
        }
    }
}
