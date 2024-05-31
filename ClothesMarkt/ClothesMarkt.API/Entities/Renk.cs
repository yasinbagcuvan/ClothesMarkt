using ClothesMarkt.Entities;

namespace ClothesMarkt.API.Entities
{
    public class Renk : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TshirtsRenkler>? Tshirts { get; set; }
        public ICollection<ShirtsRenkler>? Shirts { get; set; }
    }
}
