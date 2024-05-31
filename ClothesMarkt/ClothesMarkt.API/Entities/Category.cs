using ClothesMarkt.Entities;

namespace ClothesMarkt.API.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Tshirt>? Tshirts { get; set; }
        public IEnumerable<Shirt>? Shirts { get; set; }
    }
}
