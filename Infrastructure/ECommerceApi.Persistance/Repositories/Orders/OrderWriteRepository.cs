using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using ECommerceApi.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistance.Repositories
{
    public class OrderWriteRepository:WriteRepository<Orders> , IOrdersWriteRepository
    {
        public OrderWriteRepository(ECommerceAPIDbContext context) :base(context) 
        {

        }

    }
}
