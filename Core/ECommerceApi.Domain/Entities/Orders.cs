using ECommerceApi.Domain.Entities.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Orders:BaseEntity
    {
        public string? Description { get; set; }
        public string? Address { get; set; }
        public ICollection<Product>? Products { get; set; }
        public Customers? Customer { get; set; }
    }
}
