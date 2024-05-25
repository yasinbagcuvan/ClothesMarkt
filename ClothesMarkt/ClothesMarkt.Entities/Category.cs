using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }
		public IEnumerable<Tshirt>? Tshirts { get; set; }
		public IEnumerable<Shirt>? Shirts { get; set; }
	}
}
