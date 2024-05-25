using ClothesMarkt.Enums.OrtakEnums;
using ClothesMarkt.Enums.Tshirt;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.ViewModels
{
    public class TshirtViewModel : BaseViewModel
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal UnitPrice { get; set; }
		public CategoryViewModel Category { get; set; }
		public int CategoryId { get; set; }
		public string Picture { get; set; }
		public byte[] PictureFile { get; set; }
        public IFormFile PictureFormFile { get; set; }
        public IEnumerable<TshirtsRenklerViewModel>? Renkler { get; set; }
		public ProductSize ProductSize { get; set; }
		public KolTipi? KolTipi { get; set; }
		public KolBoyu? KolBoyu { get; set; }
		public CepTipi? CepTipi { get; set; }
		public TshirtYakaTipi? YakaTipi { get; set; }
		public TshirtKalip? Kalip { get; set; }
		public TshirtMateryal? Materyal { get; set; }
		public TshirtBaski? Baski { get; set; }
		public TshirtDokumaTipi? DokumaTipi { get; set; }

	}
}
