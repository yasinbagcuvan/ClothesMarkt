using ClothesMarkt.Enums.OrtakEnums;
using ClothesMarkt.Enums.Shirt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Dtos
{
	public class ShirtDto : BaseDto
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal UnitPrice { get; set; }
		public CategoryDto Category { get; set; }
		public int CategoryId { get; set; }
		public string Picture { get; set; }
		public byte[] PictureFile { get; set; }
		public IEnumerable<ShirtsRenklerDto>? Renkler { get; set; }
		//public IEnumerable<RenkDto>? Renkler { get; set; }
		public ProductSize ProductSize { get; set; }
		public KolTipi? KolTipi { get; set; }
		public KolBoyu? KolBoyu { get; set; }
		public CepTipi? CepTipi { get; set; }
		public ShirtBaski? ShirtBaski { get; set; }
		public ShirtDesen? ShirtDesen { get; set; }
		public ShirtDokumaTipi? ShirtDokumaTipi { get; set; }
		public ShirtKalip? ShirtKalip { get; set; }
		public ShirtKolTipi? ShirtKolTipi { get; set; }
		public ShirtKumasTipi? ShirtKumasTipi { get; set; }
		public ShirtMateryal? ShirtMateryal { get; set; }
		public ShirtYakaTipi? ShirtYakaTipi { get; set; }
	}
}
