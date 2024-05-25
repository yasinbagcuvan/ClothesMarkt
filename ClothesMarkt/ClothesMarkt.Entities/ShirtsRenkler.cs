using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public class ShirtsRenkler : BaseEntity
	{

		public int ShirtId { get; set; }
		public Shirt? Shirt { get; set; }


		public int RenkId { get; set; }
		public Renk? Renk { get; set; }
	}
}
