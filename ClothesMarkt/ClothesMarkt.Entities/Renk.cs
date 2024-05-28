using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
    public class Renk : BaseEntity
    {
        public string Name { get; set; }
		//public ICollection<TshirtsRenkler>? Tshirts { get; set; }
		//public ICollection<ShirtsRenkler>? Shirts { get; set; }

		public ICollection<Tshirt>? Tshirts { get; set; }
		public ICollection<Shirt>? Shirts { get; set; }
	}
}
