using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Dtos
{
	public class RenkDto : BaseDto
	{
		public string Name { get; set; }
		public IEnumerable<TshirtDto>? Tshirts { get; set; }
		public IEnumerable<ShirtDto>? Shirts { get; set; }
	}
}
