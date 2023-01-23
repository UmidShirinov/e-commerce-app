using ECommerceApi.Domain.Entities;
using ECommerceApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApi.Persistance.Contexts;

namespace ECommerceApi.Persistance.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customers>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
