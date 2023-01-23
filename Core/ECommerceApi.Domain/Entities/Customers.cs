using ECommerceApi.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Customers:BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Orders>?  Orders { get; set; }
    }
}
