using _3LArchitecture.Common.Entities;
using _3LArchitecture.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LArchitecture.Service
{
    public class SportsEquipmentService : BaseProductService<SportsEquipment>
    {
        public SportsEquipmentService(IProductRepository<SportsEquipment> repository) : base(repository)
        {
        }
    }
}
