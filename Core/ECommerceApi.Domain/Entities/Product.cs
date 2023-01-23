using ECommerceApi.Domain.Entities.Comman;

namespace ECommerceApi.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        public ICollection<Orders>? Orders { get; set; }
    }
}
