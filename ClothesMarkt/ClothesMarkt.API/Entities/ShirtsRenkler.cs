namespace ClothesMarkt.API.Entities
{
    public class ShirtsRenkler : BaseEntity
    {
        public int ShirtsId { get; set; }
        public Shirt Shirt { get; set; }
        public int RenklerId { get; set; }
        public Renk Renk { get; set; }
    }
}
