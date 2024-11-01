﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMarkt.ViewModels
{
	public class CategoryViewModel : BaseViewModel
	{
		public string Name { get; set; }
		public IEnumerable<TshirtViewModel>? Tshirts { get; set; }
		public IEnumerable<ShirtViewModel>? Shirts { get; set; }
	}
}
