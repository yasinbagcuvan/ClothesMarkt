using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Dtos
{
	public class ShirtsRenklerDto : BaseDto
	{
		public int ShirtDtoId { get; set; }
		public ShirtDto? Shirt { get; set; }


		public int RenkDtoId { get; set; }
		public RenkDto? Renk { get; set; }
	}
}
