using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Dtos
{
	public class CategoryDto: BaseDto
	{
		public string Name { get; set; }
		public IEnumerable<ProductDto>? Products { get; set; }
	}
	
}
