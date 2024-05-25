using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.ViewModels
{
	public class RenkViewModel : BaseViewModel
	{
		public string Name { get; set; }
		public IEnumerable<TshirtsRenklerViewModel>? Tshirts { get; set; }
		public IEnumerable<ShirtsRenklerViewModel>? Shirts { get; set; }
	}
}
