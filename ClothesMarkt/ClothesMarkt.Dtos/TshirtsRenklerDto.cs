using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Dtos
{
	public class TshirtsRenklerDto : BaseDto
	{
		public int TshirtDtoId { get; set; }
		public TshirtDto? Tshirt { get; set; }

		public int RenkDtoId { get; set; }
		public RenkDto? Renk { get; set; }
	}
}
