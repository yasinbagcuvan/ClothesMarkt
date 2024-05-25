using ClothesMarkt.Enums.OrtakEnums;
using ClothesMarkt.Enums.Shirt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.Entities
{
	public class Shirt : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal UnitPrice { get; set; }
		public Category Category { get; set; }
		public int CategoryId { get; set; }
		public string Picture { get; set; }
		public byte[] PictureFile { get; set; }
		public ICollection<ShirtsRenkler> Renkler { get; set; }
		public ProductSize ProductSize { get; set; }
		public KolTipi? KolTipi { get; set; }
		public KolBoyu? KolBoyu { get; set; }
		public CepTipi? ShirtBaski { get; set; }
		public ShirtDesen? ShirtDesen { get; set; }
		public ShirtDokumaTipi? ShirtDokumaTipi { get; set; }
		public ShirtKalip? ShirtKalip { get; set; }
		public ShirtKolTipi? ShirtKolTipi { get; set; }
		public ShirtKumasTipi? ShirtKumasTipi { get;set; }
		public ShirtMateryal? ShirtMateryal { get; set; }
		public ShirtYakaTipi? ShirtYakaTipi { get; set; }
	}
}
