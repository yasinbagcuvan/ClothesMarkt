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
		public ICollection<TshirtsRenklerViewModel>? Tshirts { get; set; } = null;
		public ICollection<ShirtsRenklerViewModel>? Shirts { get; set; } = null;
	}
}
