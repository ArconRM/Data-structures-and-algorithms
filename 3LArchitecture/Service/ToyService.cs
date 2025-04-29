using _3LArchitecture.Common.Entities;
using _3LArchitecture.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LArchitecture.Service
{
    public class ToyService : BaseProductService<Toy>
    {
        public ToyService(IProductRepository<Toy> repository) : base(repository)
        {
        }
    }
}
