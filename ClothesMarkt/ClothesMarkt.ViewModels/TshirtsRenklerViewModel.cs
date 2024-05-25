using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.ViewModels
{
	public class TshirtsRenklerViewModel : BaseViewModel
	{
		public int TshirtViewModelId { get; set; }
		public TshirtViewModel? Tshirt { get; set; }

		public int RenkViewModelId { get; set; }
		public RenkViewModel? Renk { get; set; }
	}
}
