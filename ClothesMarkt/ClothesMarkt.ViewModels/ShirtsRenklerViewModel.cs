using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.ViewModels
{
	public class ShirtsRenklerViewModel : BaseViewModel
	{
		public int ShirtViewModelId { get; set; }
		public ShirtViewModel? Shirt { get; set; }


		public int RenkViewModelId { get; set; }
		public RenkViewModel? Renk { get; set; }
	}
}
