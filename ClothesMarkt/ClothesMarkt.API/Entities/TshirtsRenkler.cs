namespace ClothesMarkt.API.Entities
{
    public class TshirtsRenkler : BaseEntity
    {
        public int TshirtId { get; set; }
        public Tshirt? Tshirt { get; set; }

        public int RenkId { get; set; }
        public Renk? Renk { get; set; }
    }
}
