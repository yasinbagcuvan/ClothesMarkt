using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public class TshirtsRenkler : BaseEntity
	{
		public int TshirtId { get; set; }
		public Tshirt? Tshirt { get; set; }

		public int RenkId { get; set; }
		public Renk? Renk { get; set; }
	}
}
