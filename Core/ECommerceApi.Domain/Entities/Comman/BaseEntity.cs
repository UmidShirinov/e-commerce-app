using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities.Comman
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDay { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
