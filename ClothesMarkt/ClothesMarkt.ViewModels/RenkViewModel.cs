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
		public ICollection<TshirtViewModel>? Tshirts { get; set; } = null;
		public ICollection<ShirtViewModel>? Shirts { get; set; } = null;
	}
}
