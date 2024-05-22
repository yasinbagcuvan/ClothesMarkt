using ClothesMarkt.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public Category Category { get; set; }
		public int CategoryId { get; set; }
		public string Picture { get; set; }
		public byte[] PictureFile { get; set; }
		public ProductSize ProductSize { get; set; }
		public IEnumerable<Color> Color { get; set; }
		public YakaTipi YakaTipi { get; set;}
		public Kalip Kalip { get; set; }
		public Materyal Materyal { get; set; }
		public KolTipi KolTipi { get; set; }
		public KolBoyu KolBoyu { get; set; }
		public  Baski Baski{ get; set; }
		public DokumaTipi DokumaTipi { get; set;}
		public CepTipi CepTipi { get; set; }
	}
}
